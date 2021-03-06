﻿using System;
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

    
    partial class MainGui_2 : Form
    {
        string[] tabStrings = { "Paket", "Empfänger", "Postfächer", "Extra"};
        public MainGui_2()
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

        private void TestGUI_Shown(object sender, EventArgs e)
        {
            refreshListItems();
        }

        private void refreshListItems()
        {
            paketListView.Items.Clear();
            panelListView.Items.Clear();
            Dictionary<string, ListViewItem[]> panelNode = new Dictionary<string, ListViewItem[]>();
            
            foreach (Paket packet in PaVe.Program.Database.Packet)
            {
                if (panelNode.Keys.Contains(packet.Panel.Name))
                    continue;
                ListViewGroup group = new ListViewGroup("Postfach " + packet.Panel.Name);
                paketListView.Groups.Add(group);
                panelListView.Items.Add(packet.Panel.Name);
                ListViewItem[] childs = PaVe.Program.Database.Packet
                    .Where(element => string.Equals(element.Panel.Name, packet.Panel.Name))
                    .Select(p => new ListViewItem(new string [] {p.ID, p.PlaceDate + "", p.PostDate + "", p.Person.Name},p.ID, group))
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
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

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
            if (panelNameTb.Text.Length == 0)
                return;
            
            panelListView.Items.Add(panelNameTb.Text);

        }

        private void loeschePanelBtn_Click(object sender, EventArgs e)
        {
            //TODO: REMOVE DATABASE ENTRY
            panelListView.Items.Remove(panelListView.FocusedItem);
        }
    }
}
