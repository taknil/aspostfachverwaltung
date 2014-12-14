namespace PaVe.InterfaceLayer.GUI
{
    partial class AddPacketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPacketForm));
            this.packetEinbuchenBtn = new System.Windows.Forms.Button();
            this.abbrechenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.postfachCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpfaenger = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // packetEinbuchenBtn
            // 
            this.packetEinbuchenBtn.Location = new System.Drawing.Point(219, 123);
            this.packetEinbuchenBtn.Name = "packetEinbuchenBtn";
            this.packetEinbuchenBtn.Size = new System.Drawing.Size(93, 32);
            this.packetEinbuchenBtn.TabIndex = 4;
            this.packetEinbuchenBtn.Text = "Einbuchen";
            this.packetEinbuchenBtn.UseVisualStyleBackColor = true;
            this.packetEinbuchenBtn.Click += new System.EventHandler(this.packetEinbuchenBtn_Click);
            // 
            // abbrechenBtn
            // 
            this.abbrechenBtn.Location = new System.Drawing.Point(120, 123);
            this.abbrechenBtn.Name = "abbrechenBtn";
            this.abbrechenBtn.Size = new System.Drawing.Size(93, 32);
            this.abbrechenBtn.TabIndex = 5;
            this.abbrechenBtn.Text = "Abbrechen";
            this.abbrechenBtn.UseVisualStyleBackColor = true;
            this.abbrechenBtn.Click += new System.EventHandler(this.abbrechenBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empfänger";
            // 
            // postfachCb
            // 
            this.postfachCb.FormattingEnabled = true;
            this.postfachCb.Location = new System.Drawing.Point(15, 87);
            this.postfachCb.Name = "postfachCb";
            this.postfachCb.Size = new System.Drawing.Size(297, 21);
            this.postfachCb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Postfach";
            // 
            // cbEmpfaenger
            // 
            this.cbEmpfaenger.FormattingEnabled = true;
            this.cbEmpfaenger.Location = new System.Drawing.Point(15, 36);
            this.cbEmpfaenger.Name = "cbEmpfaenger";
            this.cbEmpfaenger.Size = new System.Drawing.Size(297, 21);
            this.cbEmpfaenger.TabIndex = 10;
            // 
            // AddPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 183);
            this.Controls.Add(this.cbEmpfaenger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postfachCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abbrechenBtn);
            this.Controls.Add(this.packetEinbuchenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPacketForm";
            this.Text = "Packet einbuchen";
            this.Shown += new System.EventHandler(this.AddPacketForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button packetEinbuchenBtn;
        private System.Windows.Forms.Button abbrechenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox postfachCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpfaenger;

    }
}