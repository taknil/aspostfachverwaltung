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
    public partial class MainGUI : Form
    {
        public static string AvelibleID
        {
            get
            {
                return BackendWrapper.GenerateNextPacketID(PaVe.Program.Database.Packet.LastOrDefault());
            }
        }

        public MainGUI()
        {
            InitializeComponent();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void MainGUI_Shown(object sender, EventArgs e)
        {
            IDtext_lb.Text = string.Format("Last ID: {0}", AvelibleID);

            TreeNode[] nodes = RefreshTreeNodes();
            treeView1.Nodes.AddRange(nodes);
        }

        private TreeNode[] RefreshTreeNodes()
        {
            Dictionary<string, TreeNode[]> panelNode = new Dictionary<string, TreeNode[]>();
            foreach (Paket packet in PaVe.Program.Database.Packet)
            {
                if (panelNode.Keys.Contains(packet.Panel.Name))
                    continue;

                TreeNode[] childs = PaVe.Program.Database.Packet
                    .Where(element => string.Equals(element.Panel.Name, packet.Panel.Name))
                    .Select(p => new TreeNode(p.ToString()))
                    .ToArray();

                panelNode.Add(packet.Panel.ToString(), childs);
            }

            return panelNode.Select(n => new TreeNode(n.Key, n.Value))
                .ToArray();
        }

        private void Seachbar_box_TextChanged(object sender, EventArgs e)
        {
            string lookfor = Seachbar_box.Text;

            treeView1.Nodes.Clear();
            if (string.IsNullOrEmpty(lookfor) || string.IsNullOrWhiteSpace(lookfor))
            {
                treeView1.Nodes.AddRange(RefreshTreeNodes());
                return;
            }

            Dictionary<string, TreeNode[]> panelNode = new Dictionary<string, TreeNode[]>();
            TreeNode[] nodes = PaVe.Program.Database.Packet.Where(p => 
                    p.ID.Contains(lookfor) ||
                    p.Panel.ToString().Contains(lookfor) ||
                    p.Person.ToString().Contains(lookfor)

                ).Select(p => new TreeNode(p.ToString()))
                .ToArray();

            treeView1.Nodes.AddRange(nodes);
        }

        private void AddPanel_btn_Click(object sender, EventArgs e)
        {
            InputForm login = new InputForm();
            login.ShowDialog();

            login.Dispose();
            if (login.DialogResult == DialogResult.OK)
                treeView1.Nodes.Add(login.Text);

            

            //System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten0");
            //System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten2");
            //System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Knoten1", new System.Windows.Forms.TreeNode[] {
            //treeNode2});
            //this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            //treeNode1,
            //treeNode3});
        }

        private void DeletePanel_btn_Click(object sender, EventArgs e)
        {
            //REMOVE DATABASE ENTRY

            treeView1.SelectedNode.Remove();
        }

        private void AddPacket_btn_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null)
                return;

            string id = AvelibleID;
            string name = Username1_box.Text;
            string panel = treeView1.SelectedNode.Text;

            Paket packet = BackendWrapper.CreatePacket(id, name, panel);
            treeView1.SelectedNode.Nodes.Add(packet.ToString());
            treeView1.SelectedNode.Expand();

            IDtext_lb.Text = "Last ID: " + packet.ID;
            Datetext_lb.Text = packet.PlaceDate.ToString();
        }
    }
}
