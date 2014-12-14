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
            refreshPaketListItems();
            refreshNameList();
        }

        private void refreshNameList()
        {
            Console.WriteLine("refresh nameList ");
            nutzerListView.Items.Clear();
            foreach (Person person in PaVe.Program.Database.Personen)
            {
                Console.WriteLine(person.FullName);
                nutzerListView.Items.Add(person.FullName);

            }
        }

        private void refreshPaketListItems()
        {
            Console.WriteLine("refresh pakets");
            paketListView.Items.Clear();
            panelListView.Items.Clear();
            Dictionary<string, ListViewItem[]> panelNode = new Dictionary<string, ListViewItem[]>();
            
            foreach (Paket packet in PaVe.Program.Database.Pakete)
            {
                if (panelNode.Keys.Contains(packet.Panel.Name))
                    continue;

                ListViewGroup group = new ListViewGroup("Postfach " + packet.Panel.Name);
                paketListView.Groups.Add(group);
                panelListView.Items.Add(packet.Panel.Name);

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

        private void createPanelBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(panelNameTb.Text))
                return;

            BackendWrapper.CreatePostfach(panelNameTb.Text);
            panelListView.Items.Add(panelNameTb.Text);
            
        }

        private void loeschePanelBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = panelListView.FocusedItem;
            //Remove from Database
            BackendWrapper.DeletePanels(fItem.Text);
            //Remove from ListView
            panelListView.Items.Remove(fItem);
        }

        private void addNutzerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNutzerName.Text))
                return;

            BackendWrapper.CreatePostfach(tbNutzerName.Text);
            nutzerListView.Items.Add(tbNutzerName.Text);
        }

        private void deleteNutzerBtn_Click(object sender, EventArgs e)
        {
            ListViewItem fItem = nutzerListView.FocusedItem;
            //Remove from Database
            BackendWrapper.DeletePanels(fItem.Text);
            //Remove from ListView
            nutzerListView.Items.Remove(fItem);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ausbuchenBtn_Click(object sender, EventArgs e)
        {
        
        }


    }
}
