using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PaVe.DataLayer.IMDB;
using PaVe.DataLayer.Tables;

namespace PaVe.InterfaceLayer.GUI
{

    
    partial class MainGui : Form
    {
        private readonly string[] tabStrings = { "Paket", "Nutzer", "Postfächer", "Einstellungen"};
        public MainGui()
        {
            InitializeComponent();
            setText();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void setText()
        {
            int index = tabControl1.TabCount;
            for (int i = 0; i < index; i++)
            {
                tabControl1.TabPages[i].Text = tabStrings[i];
            }
            
        }

        private void GUI_Shown(object sender, EventArgs e)
        {
            refreshSettings();
            refreshPaketListItems();
            refreshNameList();
            refreshPostfachListItems();
        }

        private void refreshSettings()
        {
            SqlradioButton.Checked = PaVe.DataLayer.DataSettings.Default.UseSql;
            SqlConnection_textBox.Text = string.IsNullOrEmpty(PaVe.DataLayer.DataSettings.Default.CustomSqlConnection) ?
                PaVe.DataLayer.DataSettings.Default.Connection : PaVe.DataLayer.DataSettings.Default.CustomSqlConnection;
            SqlConnection_textBox.ReadOnly = !PaVe.DataLayer.DataSettings.Default.UseSql;
        }

        private void refreshNameList()
        {
            Console.WriteLine("refresh nameList ");
            nutzerListView.Items.Clear();
            foreach (Person person in PaVe.Program.Database.Personen)
            {
                if (postfachlListView.FindItemWithText(person.FullName) == null)
                {
                    Console.WriteLine(person.FullName);
                    nutzerListView.Items.Add(person.FullName);
                }
                
            }
        }

        private void refreshPostfachListItems()
        {
            Console.WriteLine("refresh postfaecher");
            postfachlListView.Items.Clear();
            foreach (PaVe.DataLayer.Tables.Panel panel in PaVe.Program.Database.Postfaecher)
            {
                //ListViewItem listViewItem = new ListViewItem(packet.Panel.Name);
                if (postfachlListView.FindItemWithText(panel.Name) == null)
                {
                    postfachlListView.Items.Add(panel.Name);
                }
                
            }
        }

        private void refreshPaketListItems()
        {
            Console.WriteLine("refresh pakets");
            paketListView.Items.Clear();
            Dictionary<string, ListViewItem[]> panelNode = new Dictionary<string, ListViewItem[]>();
            
            foreach (Paket packet in PaVe.Program.Database.Pakete)
            {
                if (panelNode.Keys.Contains(packet.Panel.Name))
                    continue;

                ListViewGroup group = new ListViewGroup("Postfach " + packet.Panel.Name);
                paketListView.Groups.Add(group);
                

                ListViewItem[] childs = PaVe.Program.Database.Pakete
                    .Where(element => string.Equals(element.Panel.Name, packet.Panel.Name))
                    .Select(p => new ListViewItem(new string[] 
                        {
                            p.Id.ToString(),
                            p.PlaceDate.ToString(),
                            p.Person.FullName
                        },
                        p.Id.ToString(), group))
                    .ToArray();
                
                paketListView.Items.AddRange(childs);
                panelNode.Add(packet.Panel.ToString(), childs);
            }
        }

        
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void eincheckenBtn_Click(object sender, EventArgs e)
        {
            AddPacketForm addPacketForm = new AddPacketForm();
            addPacketForm.ShowDialog();
        }

        private void erstellePostfachBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(postfachNameTb.Text))
                return;

            BackendWrapper.CreatePostfach(postfachNameTb.Text);
            refreshPostfachListItems();
            
        }

        private void loeschePostfachBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = postfachlListView.FocusedItem;
            //Remove from Database
            BackendWrapper.DeletePostfach(fItem.Text);
            //Remove from ListView
            refreshPostfachListItems();
        }

        private void addNutzerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNutzerName.Text))
                return;

            BackendWrapper.CreatePerson(tbNutzerName.Text);
            refreshNameList();
        }

        private void deleteNutzerBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = nutzerListView.FocusedItem;
            //Remove from Database
            BackendWrapper.DeletePerson(fItem.Text);
            //Remove from ListView
            refreshNameList();
        }

        private void ausbuchenBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = paketListView.FocusedItem;
            if (fItem == null)
                return;

            BackendWrapper.DeletePackets(Convert.ToInt64(fItem.Text));
            refreshPaketListItems();
        }

        private void SaveSettingsbutton_Click(object sender, EventArgs e)
        {
            PaVe.DataLayer.DataSettings.Default.UseSql = SqlradioButton.Checked;
            PaVe.DataLayer.DataSettings.Default.CustomSqlConnection = SqlConnection_textBox.Text;
            PaVe.DataLayer.DataSettings.Default.Save();
            SaveSettingsbutton.ForeColor = Color.Green;
        }

        private void XmlradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettingsbutton.ForeColor = Color.Black;

            if (XmlradioButton.Checked)
            {
                SqlradioButton.Checked = false;
                SqlConnection_textBox.ReadOnly = true;
            }
            else
            {
                SqlradioButton.Checked = true;
                SqlConnection_textBox.ReadOnly = false;
            }
        }

        private void SqlConnection_textBox_TextChanged(object sender, EventArgs e)
        {
            SaveSettingsbutton.ForeColor = Color.Black;
        }

        private void paketUmbuchenBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = paketListView.FocusedItem;
            if (fItem == null)
                return;

            AddPacketForm addPacketForm = new AddPacketForm();
            addPacketForm.ShowDialog();
        }

    }
}
