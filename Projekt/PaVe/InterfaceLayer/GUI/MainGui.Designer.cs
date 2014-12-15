namespace PaVe.InterfaceLayer.GUI
{
    partial class MainGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGui));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eincheckenBtn = new System.Windows.Forms.Button();
            this.umlagernBtn = new System.Windows.Forms.Button();
            this.ausbuchenBtn = new System.Windows.Forms.Button();
            this.paketListView = new System.Windows.Forms.ListView();
            this.PaketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aufgabedatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empfänger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteNutzerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addNutzerBtn = new System.Windows.Forms.Button();
            this.tbNutzerName = new System.Windows.Forms.TextBox();
            this.nutzerListView = new System.Windows.Forms.ListView();
            this.Nutzer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createPanelBtn = new System.Windows.Forms.Button();
            this.panelNameTb = new System.Windows.Forms.TextBox();
            this.loeschePanelBtn = new System.Windows.Forms.Button();
            this.panelListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SaveSettingsbutton = new System.Windows.Forms.Button();
            this.SqlConnection_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SqlradioButton = new System.Windows.Forms.RadioButton();
            this.XmlradioButton = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 150);
            this.tabControl1.Location = new System.Drawing.Point(29, 51);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 314);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.eincheckenBtn);
            this.tabPage1.Controls.Add(this.umlagernBtn);
            this.tabPage1.Controls.Add(this.ausbuchenBtn);
            this.tabPage1.Controls.Add(this.paketListView);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // eincheckenBtn
            // 
            this.eincheckenBtn.Location = new System.Drawing.Point(362, 6);
            this.eincheckenBtn.Name = "eincheckenBtn";
            this.eincheckenBtn.Size = new System.Drawing.Size(93, 32);
            this.eincheckenBtn.TabIndex = 4;
            this.eincheckenBtn.Text = "Einchecken";
            this.eincheckenBtn.UseVisualStyleBackColor = true;
            this.eincheckenBtn.Click += new System.EventHandler(this.eincheckenBtn_Click);
            // 
            // umlagernBtn
            // 
            this.umlagernBtn.Location = new System.Drawing.Point(118, 6);
            this.umlagernBtn.Name = "umlagernBtn";
            this.umlagernBtn.Size = new System.Drawing.Size(93, 32);
            this.umlagernBtn.TabIndex = 2;
            this.umlagernBtn.Text = "Umbuchen";
            this.umlagernBtn.UseVisualStyleBackColor = true;
            // 
            // ausbuchenBtn
            // 
            this.ausbuchenBtn.Location = new System.Drawing.Point(19, 6);
            this.ausbuchenBtn.Name = "ausbuchenBtn";
            this.ausbuchenBtn.Size = new System.Drawing.Size(93, 32);
            this.ausbuchenBtn.TabIndex = 1;
            this.ausbuchenBtn.Text = "Ausbuchen";
            this.ausbuchenBtn.UseVisualStyleBackColor = true;
            this.ausbuchenBtn.Click += new System.EventHandler(this.ausbuchenBtn_Click);
            // 
            // paketListView
            // 
            this.paketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaketID,
            this.Aufgabedatum,
            this.Empfänger});
            this.paketListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.paketListView.Location = new System.Drawing.Point(0, 57);
            this.paketListView.Name = "paketListView";
            this.paketListView.Size = new System.Drawing.Size(465, 253);
            this.paketListView.TabIndex = 0;
            this.paketListView.UseCompatibleStateImageBehavior = false;
            this.paketListView.View = System.Windows.Forms.View.Details;
            // 
            // PaketID
            // 
            this.PaketID.Text = "PaketID";
            this.PaketID.Width = 103;
            // 
            // Aufgabedatum
            // 
            this.Aufgabedatum.Text = "Aufgabedatum";
            this.Aufgabedatum.Width = 185;
            // 
            // Empfänger
            // 
            this.Empfänger.Text = "Empfänger";
            this.Empfänger.Width = 172;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteNutzerBtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.nutzerListView);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteNutzerBtn
            // 
            this.deleteNutzerBtn.Location = new System.Drawing.Point(285, 192);
            this.deleteNutzerBtn.Name = "deleteNutzerBtn";
            this.deleteNutzerBtn.Size = new System.Drawing.Size(162, 36);
            this.deleteNutzerBtn.TabIndex = 2;
            this.deleteNutzerBtn.Text = "Nutzer löschen";
            this.deleteNutzerBtn.UseVisualStyleBackColor = true;
            this.deleteNutzerBtn.Click += new System.EventHandler(this.deleteNutzerBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addNutzerBtn);
            this.groupBox2.Controls.Add(this.tbNutzerName);
            this.groupBox2.Location = new System.Drawing.Point(279, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nutzer anlegen";
            // 
            // addNutzerBtn
            // 
            this.addNutzerBtn.Location = new System.Drawing.Point(6, 58);
            this.addNutzerBtn.Name = "addNutzerBtn";
            this.addNutzerBtn.Size = new System.Drawing.Size(162, 36);
            this.addNutzerBtn.TabIndex = 1;
            this.addNutzerBtn.Text = "Hinzufügen";
            this.addNutzerBtn.UseVisualStyleBackColor = true;
            this.addNutzerBtn.Click += new System.EventHandler(this.addNutzerBtn_Click);
            // 
            // tbNutzerName
            // 
            this.tbNutzerName.Location = new System.Drawing.Point(6, 32);
            this.tbNutzerName.Name = "tbNutzerName";
            this.tbNutzerName.Size = new System.Drawing.Size(162, 20);
            this.tbNutzerName.TabIndex = 0;
            // 
            // nutzerListView
            // 
            this.nutzerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nutzer});
            this.nutzerListView.Location = new System.Drawing.Point(0, 0);
            this.nutzerListView.Name = "nutzerListView";
            this.nutzerListView.Size = new System.Drawing.Size(273, 300);
            this.nutzerListView.TabIndex = 0;
            this.nutzerListView.UseCompatibleStateImageBehavior = false;
            this.nutzerListView.View = System.Windows.Forms.View.Details;
            // 
            // Nutzer
            // 
            this.Nutzer.Text = "Nutzer";
            this.Nutzer.Width = 265;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.loeschePanelBtn);
            this.tabPage3.Controls.Add(this.panelListView);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(461, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createPanelBtn);
            this.groupBox1.Controls.Add(this.panelNameTb);
            this.groupBox1.Location = new System.Drawing.Point(279, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postfach erstellen";
            // 
            // createPanelBtn
            // 
            this.createPanelBtn.Location = new System.Drawing.Point(6, 58);
            this.createPanelBtn.Name = "createPanelBtn";
            this.createPanelBtn.Size = new System.Drawing.Size(155, 36);
            this.createPanelBtn.TabIndex = 1;
            this.createPanelBtn.Text = "Erstellen";
            this.createPanelBtn.UseVisualStyleBackColor = true;
            this.createPanelBtn.Click += new System.EventHandler(this.createPanelBtn_Click);
            // 
            // panelNameTb
            // 
            this.panelNameTb.Location = new System.Drawing.Point(6, 32);
            this.panelNameTb.Name = "panelNameTb";
            this.panelNameTb.Size = new System.Drawing.Size(155, 20);
            this.panelNameTb.TabIndex = 3;
            // 
            // loeschePanelBtn
            // 
            this.loeschePanelBtn.Location = new System.Drawing.Point(296, 250);
            this.loeschePanelBtn.Name = "loeschePanelBtn";
            this.loeschePanelBtn.Size = new System.Drawing.Size(144, 36);
            this.loeschePanelBtn.TabIndex = 2;
            this.loeschePanelBtn.Text = "Postfach löschen";
            this.loeschePanelBtn.UseVisualStyleBackColor = true;
            this.loeschePanelBtn.Click += new System.EventHandler(this.loeschePanelBtn_Click);
            // 
            // panelListView
            // 
            this.panelListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.panelListView.Location = new System.Drawing.Point(0, 0);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(273, 310);
            this.panelListView.TabIndex = 0;
            this.panelListView.UseCompatibleStateImageBehavior = false;
            this.panelListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Postfächer";
            this.columnHeader1.Width = 265;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.SaveSettingsbutton);
            this.tabPage5.Controls.Add(this.SqlConnection_textBox);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Location = new System.Drawing.Point(154, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(461, 306);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsbutton
            // 
            this.SaveSettingsbutton.Location = new System.Drawing.Point(370, 277);
            this.SaveSettingsbutton.Name = "SaveSettingsbutton";
            this.SaveSettingsbutton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsbutton.TabIndex = 2;
            this.SaveSettingsbutton.Text = "&Save";
            this.SaveSettingsbutton.UseVisualStyleBackColor = true;
            this.SaveSettingsbutton.Click += new System.EventHandler(this.SaveSettingsbutton_Click);
            // 
            // SqlConnection_textBox
            // 
            this.SqlConnection_textBox.Location = new System.Drawing.Point(24, 146);
            this.SqlConnection_textBox.Name = "SqlConnection_textBox";
            this.SqlConnection_textBox.Size = new System.Drawing.Size(421, 20);
            this.SqlConnection_textBox.TabIndex = 1;
            this.SqlConnection_textBox.TextChanged += new System.EventHandler(this.SqlConnection_textBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SqlradioButton);
            this.groupBox3.Controls.Add(this.XmlradioButton);
            this.groupBox3.Location = new System.Drawing.Point(24, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daten laden aus";
            // 
            // SqlradioButton
            // 
            this.SqlradioButton.AutoSize = true;
            this.SqlradioButton.Location = new System.Drawing.Point(13, 53);
            this.SqlradioButton.Name = "SqlradioButton";
            this.SqlradioButton.Size = new System.Drawing.Size(46, 17);
            this.SqlradioButton.TabIndex = 1;
            this.SqlradioButton.Text = "SQL";
            this.SqlradioButton.UseVisualStyleBackColor = true;
            // 
            // XmlradioButton
            // 
            this.XmlradioButton.AutoSize = true;
            this.XmlradioButton.Checked = true;
            this.XmlradioButton.Location = new System.Drawing.Point(12, 29);
            this.XmlradioButton.Name = "XmlradioButton";
            this.XmlradioButton.Size = new System.Drawing.Size(47, 17);
            this.XmlradioButton.TabIndex = 0;
            this.XmlradioButton.TabStop = true;
            this.XmlradioButton.Text = "XML";
            this.XmlradioButton.UseVisualStyleBackColor = true;
            this.XmlradioButton.CheckedChanged += new System.EventHandler(this.XmlradioButton_CheckedChanged);
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 392);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGui";
            this.Text = "PaVe [GUI] - Die Paketverwaltung";
            this.Activated += new System.EventHandler(this.GUI_Shown);
            this.Shown += new System.EventHandler(this.GUI_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView paketListView;
        private System.Windows.Forms.ColumnHeader PaketID;
        private System.Windows.Forms.ColumnHeader Aufgabedatum;
        private System.Windows.Forms.ColumnHeader Empfänger;
        private System.Windows.Forms.Button eincheckenBtn;
        private System.Windows.Forms.Button umlagernBtn;
        private System.Windows.Forms.Button ausbuchenBtn;
        private System.Windows.Forms.Button loeschePanelBtn;
        private System.Windows.Forms.Button createPanelBtn;
        private System.Windows.Forms.ListView panelListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox panelNameTb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button deleteNutzerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addNutzerBtn;
        private System.Windows.Forms.TextBox tbNutzerName;
        private System.Windows.Forms.ListView nutzerListView;
        private System.Windows.Forms.ColumnHeader Nutzer;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SqlradioButton;
        private System.Windows.Forms.RadioButton XmlradioButton;
        private System.Windows.Forms.Button SaveSettingsbutton;
        private System.Windows.Forms.TextBox SqlConnection_textBox;

        
            
            


            
    }
}