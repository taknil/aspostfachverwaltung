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
    public partial class AddPacketForm : Form
    {
        public AddPacketForm()
        {
            InitializeComponent();
            postfachCb.Items.Insert(0, "-WÄHLE POSTFACH-");
            postfachCb.SelectedIndex = 0;
        }

        public static string AvailableID
        {
            get
            {
                return BackendWrapper.GenerateNextPacketID(PaVe.Program.Database.Packet.LastOrDefault());
            }
        }

        private void AddPacketForm_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Start add Items");
            addItemsToCombobox();
        }


        private void addItemsToCombobox()
        {
            Console.WriteLine("Start add Items");
            string[] panel = PaVe.Program.Database.Packet
                    .Select(p => p.Panel.Name )
                    .Distinct()
                    .ToArray();
            Console.WriteLine(panel.Length);
            Console.WriteLine(panel);
            postfachCb.Items.AddRange(panel);
        }

        private void packetEinbuchenBtn_Click(object sender, EventArgs e)
        {
            string id = AvailableID;
            string name = empfaengerTb.Text;
            string panel = postfachCb.SelectedItem.ToString();

            Paket packet = BackendWrapper.CreatePacket(id, name, panel);
            this.Close();
        }

        private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
