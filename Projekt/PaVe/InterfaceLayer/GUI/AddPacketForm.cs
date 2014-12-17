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
        private const string DefaultEmpfaengerCbText = "-WÄHLE EMPFÄNGER-";

        private bool EditPaket = false;
        private Paket paket;

        public AddPacketForm()
        {
            InitializeComponent();
            postfachCb.Items.Insert(0, DefaultPostfachCbText);
            postfachCb.SelectedIndex = 0;
            cbEmpfaenger.Items.Insert(0, DefaultEmpfaengerCbText);
            cbEmpfaenger.SelectedIndex = 0;
        }

        public AddPacketForm(PaVe.DataLayer.Tables.Paket paket)
        {
            InitializeComponent();
            this.paket = paket;
            this.EditPaket = true;
            postfachCb.SelectedIndex = postfachCb.Items.IndexOf(paket.Panel.Name);
            cbEmpfaenger.SelectedIndex = cbEmpfaenger.Items.IndexOf(paket.Person.FullName);
            cbEmpfaenger.Enabled = false;
        }

        private void AddPacketForm_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("Start add Items");
            addItemsToCombobox();
        }


        private void addItemsToCombobox()
        {
            Debug.WriteLine("Start add Items");
            string[] panels = PaVe.Program.Database.Postfaecher
                    .Select(p => p.Name )
                    .Distinct()
                    .ToArray();
            Debug.WriteLine(panels.Length);
            postfachCb.Items.AddRange(panels);

            string[] empfaenger = PaVe.Program.Database.Personen
                    .Select(p => p.FullName)
                    .Distinct()
                    .ToArray();
            Debug.WriteLine(empfaenger.Length);
            cbEmpfaenger.Items.AddRange(empfaenger);
            if (EditPaket)
            {
                postfachCb.SelectedIndex = postfachCb.Items.IndexOf(paket.Panel.Name);
                cbEmpfaenger.SelectedIndex = cbEmpfaenger.Items.IndexOf(paket.Person.FullName);

            }
        }

        private void packetEinbuchenBtn_Click(object sender, EventArgs e)
        {
            string name = cbEmpfaenger.SelectedItem.ToString();
            if (name.Equals(DefaultEmpfaengerCbText))
            {
                return;
            }
            string panel = postfachCb.SelectedItem.ToString();
            if (panel.Equals(DefaultPostfachCbText))
            {
                return;
            }
            if (EditPaket) {
                BackendWrapper.DeletePackets(paket.Id);
            }
            if(string.Equals(panel, DefaultPostfachCbText) == false)
                BackendWrapper.CreatePacket(name, panel);

            this.Close();
        }

        private void abbrechenBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
