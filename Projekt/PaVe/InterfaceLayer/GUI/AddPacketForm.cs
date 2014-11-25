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
using System.Diagnostics;

namespace PaVe.InterfaceLayer.GUI
{
    public partial class AddPacketForm : Form
    {
        private const string DefaultPostfachCbText = "-WÄHLE POSTFACH-";

        public AddPacketForm()
        {
            InitializeComponent();
            postfachCb.Items.Insert(0, DefaultPostfachCbText);
            postfachCb.SelectedIndex = 0;
        }

        private void AddPacketForm_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("Start add Items");
            addItemsToCombobox();
        }


        private void addItemsToCombobox()
        {
            Debug.WriteLine("Start add Items");
            string[] panels = PaVe.Program.Database.Packet
                    .Select(p => p.Panel.Name )
                    .Distinct()
                    .ToArray();
            Debug.WriteLine(panels.Length);
            postfachCb.Items.AddRange(panels);
        }

        private void packetEinbuchenBtn_Click(object sender, EventArgs e)
        {
            string id = BackendWrapper.NextID;
            string name = empfaengerTb.Text;
            string panel = postfachCb.SelectedItem.ToString();

            if(string.Equals(panel, DefaultPostfachCbText) == false)
                BackendWrapper.CreatePacket(id, name, panel);

            this.Close();
        }

        private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
