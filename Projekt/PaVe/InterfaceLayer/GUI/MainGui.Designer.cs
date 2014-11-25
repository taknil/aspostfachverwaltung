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
            this.vernichtenBtn = new System.Windows.Forms.Button();
            this.umlagernBtn = new System.Windows.Forms.Button();
            this.ausbuchenBtn = new System.Windows.Forms.Button();
            this.paketListView = new System.Windows.Forms.ListView();
            this.PaketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aufgabedatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abholdatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Empfänger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createPanelBtn = new System.Windows.Forms.Button();
            this.panelNameTb = new System.Windows.Forms.TextBox();
            this.loeschePanelBtn = new System.Windows.Forms.Button();
            this.panelListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.Controls.Add(this.vernichtenBtn);
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
            // vernichtenBtn
            // 
            this.vernichtenBtn.Location = new System.Drawing.Point(217, 6);
            this.vernichtenBtn.Name = "vernichtenBtn";
            this.vernichtenBtn.Size = new System.Drawing.Size(93, 32);
            this.vernichtenBtn.TabIndex = 3;
            this.vernichtenBtn.Text = "Vernichten";
            this.vernichtenBtn.UseVisualStyleBackColor = true;
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
            // 
            // paketListView
            // 
            this.paketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PaketID,
            this.Aufgabedatum,
            this.Abholdatum,
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
            // 
            // Aufgabedatum
            // 
            this.Aufgabedatum.Text = "Aufgabedatum";
            this.Aufgabedatum.Width = 120;
            // 
            // Abholdatum
            // 
            this.Abholdatum.Text = "Abholdatum";
            this.Abholdatum.Width = 120;
            // 
            // Empfänger
            // 
            this.Empfänger.Text = "Empfänger";
            this.Empfänger.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.columnHeader1.Width = 262;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage4.Size = new System.Drawing.Size(461, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView paketListView;
        private System.Windows.Forms.ColumnHeader PaketID;
        private System.Windows.Forms.ColumnHeader Aufgabedatum;
        private System.Windows.Forms.ColumnHeader Abholdatum;
        private System.Windows.Forms.ColumnHeader Empfänger;
        private System.Windows.Forms.Button eincheckenBtn;
        private System.Windows.Forms.Button vernichtenBtn;
        private System.Windows.Forms.Button umlagernBtn;
        private System.Windows.Forms.Button ausbuchenBtn;
        private System.Windows.Forms.Button loeschePanelBtn;
        private System.Windows.Forms.Button createPanelBtn;
        private System.Windows.Forms.ListView panelListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox panelNameTb;
        private System.Windows.Forms.ColumnHeader columnHeader1;

        
            
            


            
    }
}