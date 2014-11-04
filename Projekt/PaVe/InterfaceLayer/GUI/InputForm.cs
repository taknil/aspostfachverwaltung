using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaVe.InterfaceLayer.GUI
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            string result = this.input_box.Text;

            if (string.IsNullOrEmpty(result))
            {
                this.DialogResult = DialogResult.Abort;
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Text = this.input_box.Text;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
