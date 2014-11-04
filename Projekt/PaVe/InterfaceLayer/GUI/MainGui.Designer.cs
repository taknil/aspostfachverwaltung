namespace PaVe.InterfaceLayer.GUI
{
    partial class MainGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Seachbar_box = new System.Windows.Forms.TextBox();
            this.Logbar_box = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddPanel_btn = new System.Windows.Forms.Button();
            this.DeletePanel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Datetext_lb = new System.Windows.Forms.Label();
            this.IDtext_lb = new System.Windows.Forms.Label();
            this.PWDGenerate_btn = new System.Windows.Forms.Button();
            this.PWD_Box = new System.Windows.Forms.TextBox();
            this.Username1_box = new System.Windows.Forms.TextBox();
            this.AddPacket_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seachbar_box
            // 
            this.Seachbar_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Seachbar_box.Location = new System.Drawing.Point(0, 0);
            this.Seachbar_box.Name = "Seachbar_box";
            this.Seachbar_box.Size = new System.Drawing.Size(496, 20);
            this.Seachbar_box.TabIndex = 0;
            this.Seachbar_box.TextChanged += new System.EventHandler(this.Seachbar_box_TextChanged);
            // 
            // Logbar_box
            // 
            this.Logbar_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logbar_box.Location = new System.Drawing.Point(0, 407);
            this.Logbar_box.Multiline = true;
            this.Logbar_box.Name = "Logbar_box";
            this.Logbar_box.ReadOnly = true;
            this.Logbar_box.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Logbar_box.Size = new System.Drawing.Size(496, 20);
            this.Logbar_box.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(313, 338);
            this.treeView1.TabIndex = 2;
            // 
            // AddPanel_btn
            // 
            this.AddPanel_btn.Location = new System.Drawing.Point(13, 371);
            this.AddPanel_btn.Name = "AddPanel_btn";
            this.AddPanel_btn.Size = new System.Drawing.Size(75, 23);
            this.AddPanel_btn.TabIndex = 3;
            this.AddPanel_btn.Text = "+";
            this.AddPanel_btn.UseVisualStyleBackColor = true;
            this.AddPanel_btn.Click += new System.EventHandler(this.AddPanel_btn_Click);
            // 
            // DeletePanel_btn
            // 
            this.DeletePanel_btn.Location = new System.Drawing.Point(251, 371);
            this.DeletePanel_btn.Name = "DeletePanel_btn";
            this.DeletePanel_btn.Size = new System.Drawing.Size(75, 23);
            this.DeletePanel_btn.TabIndex = 4;
            this.DeletePanel_btn.Text = "x";
            this.DeletePanel_btn.UseVisualStyleBackColor = true;
            this.DeletePanel_btn.Click += new System.EventHandler(this.DeletePanel_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPacket_btn);
            this.groupBox1.Controls.Add(this.Datetext_lb);
            this.groupBox1.Controls.Add(this.PWDGenerate_btn);
            this.groupBox1.Controls.Add(this.PWD_Box);
            this.groupBox1.Controls.Add(this.Username1_box);
            this.groupBox1.Location = new System.Drawing.Point(335, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paket";
            // 
            // Datetext_lb
            // 
            this.Datetext_lb.AutoSize = true;
            this.Datetext_lb.Location = new System.Drawing.Point(4, 74);
            this.Datetext_lb.Name = "Datetext_lb";
            this.Datetext_lb.Size = new System.Drawing.Size(45, 13);
            this.Datetext_lb.TabIndex = 4;
            this.Datetext_lb.Text = "Zeit: {0}";
            // 
            // IDtext_lb
            // 
            this.IDtext_lb.AutoSize = true;
            this.IDtext_lb.Location = new System.Drawing.Point(332, 27);
            this.IDtext_lb.Name = "IDtext_lb";
            this.IDtext_lb.Size = new System.Drawing.Size(61, 13);
            this.IDtext_lb.TabIndex = 3;
            this.IDtext_lb.Text = "Last ID: {0}";
            // 
            // PWDGenerate_btn
            // 
            this.PWDGenerate_btn.Location = new System.Drawing.Point(114, 43);
            this.PWDGenerate_btn.Name = "PWDGenerate_btn";
            this.PWDGenerate_btn.Size = new System.Drawing.Size(24, 23);
            this.PWDGenerate_btn.TabIndex = 2;
            this.PWDGenerate_btn.Text = "R";
            this.PWDGenerate_btn.UseVisualStyleBackColor = true;
            // 
            // PWD_Box
            // 
            this.PWD_Box.Location = new System.Drawing.Point(7, 47);
            this.PWD_Box.Name = "PWD_Box";
            this.PWD_Box.Size = new System.Drawing.Size(100, 20);
            this.PWD_Box.TabIndex = 1;
            // 
            // Username1_box
            // 
            this.Username1_box.Location = new System.Drawing.Point(7, 20);
            this.Username1_box.Name = "Username1_box";
            this.Username1_box.Size = new System.Drawing.Size(100, 20);
            this.Username1_box.TabIndex = 0;
            // 
            // AddPacket_btn
            // 
            this.AddPacket_btn.Location = new System.Drawing.Point(7, 90);
            this.AddPacket_btn.Name = "AddPacket_btn";
            this.AddPacket_btn.Size = new System.Drawing.Size(75, 23);
            this.AddPacket_btn.TabIndex = 5;
            this.AddPacket_btn.Text = "Add";
            this.AddPacket_btn.UseVisualStyleBackColor = true;
            this.AddPacket_btn.Click += new System.EventHandler(this.AddPacket_btn_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeletePanel_btn);
            this.Controls.Add(this.IDtext_lb);
            this.Controls.Add(this.AddPanel_btn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Logbar_box);
            this.Controls.Add(this.Seachbar_box);
            this.Name = "MainGUI";
            this.Text = "PaVe GUI - Die Paketverwaltung";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.Shown += new System.EventHandler(this.MainGUI_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Seachbar_box;
        private System.Windows.Forms.TextBox Logbar_box;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddPanel_btn;
        private System.Windows.Forms.Button DeletePanel_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Datetext_lb;
        private System.Windows.Forms.Label IDtext_lb;
        private System.Windows.Forms.Button PWDGenerate_btn;
        private System.Windows.Forms.TextBox PWD_Box;
        private System.Windows.Forms.TextBox Username1_box;
        private System.Windows.Forms.Button AddPacket_btn;
    }
}

