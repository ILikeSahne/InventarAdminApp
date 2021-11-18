﻿
namespace InventarAdminApp
{
    partial class Form1
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
            this.serverDropDown = new System.Windows.Forms.ComboBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.itemTable = new System.Windows.Forms.DataGridView();
            this.Anlage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unternummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AktuelleInventarNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AktivierungAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anlagenbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serialnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnschaffungsWert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuchWert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waehrung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KfzKennzeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaumBezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // serverDropDown
            // 
            this.serverDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverDropDown.FormattingEnabled = true;
            this.serverDropDown.Location = new System.Drawing.Point(110, 32);
            this.serverDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serverDropDown.Name = "serverDropDown";
            this.serverDropDown.Size = new System.Drawing.Size(223, 28);
            this.serverDropDown.Sorted = true;
            this.serverDropDown.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(110, 75);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(223, 26);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "TestUser";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(110, 115);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(223, 26);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.Text = "Test123!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDatabaseToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 32);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // addNewDatabaseToolStripMenuItem
            // 
            this.addNewDatabaseToolStripMenuItem.Name = "addNewDatabaseToolStripMenuItem";
            this.addNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.addNewDatabaseToolStripMenuItem.Text = "Add new Database";
            this.addNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addNewDatabaseToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.addNewUserToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewItemToolStripMenuItem.Text = "Add new Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewUserToolStripMenuItem.Text = "Add new User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(18, 187);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(125, 20);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Nothing here yet";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(22, 149);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(311, 35);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // itemTable
            // 
            this.itemTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anlage,
            this.Unternummer,
            this.AktuelleInventarNummer,
            this.AktivierungAm,
            this.Anlagenbezeichnung,
            this.Serialnummer,
            this.AnschaffungsWert,
            this.BuchWert,
            this.Waehrung,
            this.KfzKennzeichen,
            this.Raum,
            this.RaumBezeichnung});
            this.itemTable.Location = new System.Drawing.Point(349, 32);
            this.itemTable.Name = "itemTable";
            this.itemTable.RowHeadersWidth = 50;
            this.itemTable.RowTemplate.Height = 28;
            this.itemTable.Size = new System.Drawing.Size(839, 648);
            this.itemTable.TabIndex = 10;
            // 
            // Anlage
            // 
            this.Anlage.HeaderText = "Anlage";
            this.Anlage.MinimumWidth = 8;
            this.Anlage.Name = "Anlage";
            // 
            // Unternummer
            // 
            this.Unternummer.HeaderText = "Untern.";
            this.Unternummer.MinimumWidth = 8;
            this.Unternummer.Name = "Unternummer";
            // 
            // AktuelleInventarNummer
            // 
            this.AktuelleInventarNummer.HeaderText = "AktuelleN.";
            this.AktuelleInventarNummer.MinimumWidth = 8;
            this.AktuelleInventarNummer.Name = "AktuelleInventarNummer";
            // 
            // AktivierungAm
            // 
            this.AktivierungAm.HeaderText = "AktivierungAm";
            this.AktivierungAm.MinimumWidth = 8;
            this.AktivierungAm.Name = "AktivierungAm";
            // 
            // Anlagenbezeichnung
            // 
            this.Anlagenbezeichnung.HeaderText = "Anlagenb.";
            this.Anlagenbezeichnung.MinimumWidth = 8;
            this.Anlagenbezeichnung.Name = "Anlagenbezeichnung";
            // 
            // Serialnummer
            // 
            this.Serialnummer.HeaderText = "Serialn.";
            this.Serialnummer.MinimumWidth = 8;
            this.Serialnummer.Name = "Serialnummer";
            // 
            // AnschaffungsWert
            // 
            this.AnschaffungsWert.HeaderText = "AnschWert";
            this.AnschaffungsWert.MinimumWidth = 8;
            this.AnschaffungsWert.Name = "AnschaffungsWert";
            // 
            // BuchWert
            // 
            this.BuchWert.HeaderText = "BuchWert";
            this.BuchWert.MinimumWidth = 8;
            this.BuchWert.Name = "BuchWert";
            // 
            // Waehrung
            // 
            this.Waehrung.HeaderText = "Waehrung";
            this.Waehrung.MinimumWidth = 8;
            this.Waehrung.Name = "Waehrung";
            // 
            // KfzKennzeichen
            // 
            this.KfzKennzeichen.HeaderText = "KfzK.";
            this.KfzKennzeichen.MinimumWidth = 8;
            this.KfzKennzeichen.Name = "KfzKennzeichen";
            // 
            // Raum
            // 
            this.Raum.HeaderText = "Raum";
            this.Raum.MinimumWidth = 8;
            this.Raum.Name = "Raum";
            // 
            // RaumBezeichnung
            // 
            this.RaumBezeichnung.HeaderText = "RaumB.";
            this.RaumBezeichnung.MinimumWidth = 8;
            this.RaumBezeichnung.Name = "RaumBezeichnung";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(12, 645);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 35);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.itemTable);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.serverDropDown);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverDropDown;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.DataGridView itemTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anlage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unternummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AktuelleInventarNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AktivierungAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anlagenbezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serialnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnschaffungsWert;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuchWert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waehrung;
        private System.Windows.Forms.DataGridViewTextBoxColumn KfzKennzeichen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaumBezeichnung;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
    }
}

