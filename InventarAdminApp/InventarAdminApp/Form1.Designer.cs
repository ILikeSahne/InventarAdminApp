
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
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label4 = new System.Windows.Forms.Label();
            this.itemCollectionDropDown = new System.Windows.Forms.ComboBox();
            this.showItemsButton = new System.Windows.Forms.Button();
            this.itemCollectionNameInput = new System.Windows.Forms.TextBox();
            this.addItemCollectionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemCollectionPermissionInput = new System.Windows.Forms.TextBox();
            this.removeItemCollectionButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.copyItemCollectionButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // serverDropDown
            // 
            this.serverDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverDropDown.FormattingEnabled = true;
            this.serverDropDown.Location = new System.Drawing.Point(73, 21);
            this.serverDropDown.Name = "serverDropDown";
            this.serverDropDown.Size = new System.Drawing.Size(150, 21);
            this.serverDropDown.Sorted = true;
            this.serverDropDown.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(73, 49);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(150, 20);
            this.nameInput.TabIndex = 1;
            this.nameInput.Text = "TestUser";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(73, 75);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(150, 20);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.Text = "Test123!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDatabaseToolStripMenuItem,
            this.showUsersToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // addNewDatabaseToolStripMenuItem
            // 
            this.addNewDatabaseToolStripMenuItem.Name = "addNewDatabaseToolStripMenuItem";
            this.addNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addNewDatabaseToolStripMenuItem.Text = "Add new Database";
            this.addNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addNewDatabaseToolStripMenuItem_Click);
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.showUsersToolStripMenuItem.Text = "Show Users";
            this.showUsersToolStripMenuItem.Click += new System.EventHandler(this.showUsersToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.loadExcelFileToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addNewItemToolStripMenuItem.Text = "Add new Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addNewUserToolStripMenuItem.Text = "Add new User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // loadExcelFileToolStripMenuItem
            // 
            this.loadExcelFileToolStripMenuItem.Name = "loadExcelFileToolStripMenuItem";
            this.loadExcelFileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadExcelFileToolStripMenuItem.Text = "Load Excel File";
            this.loadExcelFileToolStripMenuItem.Click += new System.EventHandler(this.loadExcelFileToolStripMenuItem_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 122);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(85, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Nothing here yet";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(15, 97);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(207, 23);
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
            this.itemTable.Location = new System.Drawing.Point(233, 21);
            this.itemTable.Margin = new System.Windows.Forms.Padding(2);
            this.itemTable.Name = "itemTable";
            this.itemTable.RowHeadersWidth = 50;
            this.itemTable.RowTemplate.Height = 28;
            this.itemTable.Size = new System.Drawing.Size(559, 421);
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
            this.deleteButton.Location = new System.Drawing.Point(8, 419);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Collection";
            // 
            // itemCollectionDropDown
            // 
            this.itemCollectionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCollectionDropDown.FormattingEnabled = true;
            this.itemCollectionDropDown.Location = new System.Drawing.Point(15, 161);
            this.itemCollectionDropDown.Name = "itemCollectionDropDown";
            this.itemCollectionDropDown.Size = new System.Drawing.Size(209, 21);
            this.itemCollectionDropDown.Sorted = true;
            this.itemCollectionDropDown.TabIndex = 13;
            // 
            // showItemsButton
            // 
            this.showItemsButton.Location = new System.Drawing.Point(15, 185);
            this.showItemsButton.Margin = new System.Windows.Forms.Padding(2);
            this.showItemsButton.Name = "showItemsButton";
            this.showItemsButton.Size = new System.Drawing.Size(207, 23);
            this.showItemsButton.TabIndex = 14;
            this.showItemsButton.Text = "Show Items";
            this.showItemsButton.UseVisualStyleBackColor = true;
            this.showItemsButton.Click += new System.EventHandler(this.showItemsButton_Click);
            // 
            // itemCollectionNameInput
            // 
            this.itemCollectionNameInput.Location = new System.Drawing.Point(73, 213);
            this.itemCollectionNameInput.Name = "itemCollectionNameInput";
            this.itemCollectionNameInput.Size = new System.Drawing.Size(148, 20);
            this.itemCollectionNameInput.TabIndex = 15;
            // 
            // addItemCollectionButton
            // 
            this.addItemCollectionButton.Location = new System.Drawing.Point(15, 259);
            this.addItemCollectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemCollectionButton.Name = "addItemCollectionButton";
            this.addItemCollectionButton.Size = new System.Drawing.Size(207, 23);
            this.addItemCollectionButton.TabIndex = 16;
            this.addItemCollectionButton.Text = "Add Item Collection";
            this.addItemCollectionButton.UseVisualStyleBackColor = true;
            this.addItemCollectionButton.Click += new System.EventHandler(this.addItemCollectionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Permission";
            // 
            // itemCollectionPermissionInput
            // 
            this.itemCollectionPermissionInput.Location = new System.Drawing.Point(73, 237);
            this.itemCollectionPermissionInput.Name = "itemCollectionPermissionInput";
            this.itemCollectionPermissionInput.Size = new System.Drawing.Size(148, 20);
            this.itemCollectionPermissionInput.TabIndex = 19;
            // 
            // removeItemCollectionButton
            // 
            this.removeItemCollectionButton.Location = new System.Drawing.Point(15, 286);
            this.removeItemCollectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeItemCollectionButton.Name = "removeItemCollectionButton";
            this.removeItemCollectionButton.Size = new System.Drawing.Size(207, 23);
            this.removeItemCollectionButton.TabIndex = 20;
            this.removeItemCollectionButton.Text = "Remove Item Collection";
            this.removeItemCollectionButton.UseVisualStyleBackColor = true;
            this.removeItemCollectionButton.Click += new System.EventHandler(this.removeItemCollectionButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // copyItemCollectionButton
            // 
            this.copyItemCollectionButton.Location = new System.Drawing.Point(15, 313);
            this.copyItemCollectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.copyItemCollectionButton.Name = "copyItemCollectionButton";
            this.copyItemCollectionButton.Size = new System.Drawing.Size(207, 23);
            this.copyItemCollectionButton.TabIndex = 21;
            this.copyItemCollectionButton.Text = "Copy Item Collection";
            this.copyItemCollectionButton.UseVisualStyleBackColor = true;
            this.copyItemCollectionButton.Click += new System.EventHandler(this.copyItemCollectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyItemCollectionButton);
            this.Controls.Add(this.removeItemCollectionButton);
            this.Controls.Add(this.itemCollectionPermissionInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addItemCollectionButton);
            this.Controls.Add(this.itemCollectionNameInput);
            this.Controls.Add(this.showItemsButton);
            this.Controls.Add(this.itemCollectionDropDown);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemCollectionDropDown;
        private System.Windows.Forms.Button showItemsButton;
        private System.Windows.Forms.TextBox itemCollectionNameInput;
        private System.Windows.Forms.Button addItemCollectionButton;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemCollectionPermissionInput;
        private System.Windows.Forms.Button removeItemCollectionButton;
        private System.Windows.Forms.ToolStripMenuItem loadExcelFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button copyItemCollectionButton;
    }
}

