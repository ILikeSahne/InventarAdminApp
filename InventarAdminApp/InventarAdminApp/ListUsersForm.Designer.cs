
namespace InventarAdminApp
{
    partial class ListUsersForm
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
            this.userdataTable = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.permissionInput = new System.Windows.Forms.TextBox();
            this.addPermissionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userdataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userdataTable
            // 
            this.userdataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userdataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userdataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.Username,
            this.Permissions});
            this.userdataTable.Location = new System.Drawing.Point(160, 12);
            this.userdataTable.Name = "userdataTable";
            this.userdataTable.Size = new System.Drawing.Size(628, 426);
            this.userdataTable.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Permissions
            // 
            this.Permissions.HeaderText = "Permissions";
            this.Permissions.Name = "Permissions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permission:";
            // 
            // permissionInput
            // 
            this.permissionInput.Location = new System.Drawing.Point(16, 30);
            this.permissionInput.Name = "permissionInput";
            this.permissionInput.Size = new System.Drawing.Size(138, 20);
            this.permissionInput.TabIndex = 2;
            // 
            // addPermissionButton
            // 
            this.addPermissionButton.Location = new System.Drawing.Point(16, 57);
            this.addPermissionButton.Name = "addPermissionButton";
            this.addPermissionButton.Size = new System.Drawing.Size(138, 23);
            this.addPermissionButton.TabIndex = 3;
            this.addPermissionButton.Text = "Add";
            this.addPermissionButton.UseVisualStyleBackColor = true;
            this.addPermissionButton.Click += new System.EventHandler(this.addPermissionButton_Click);
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPermissionButton);
            this.Controls.Add(this.permissionInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userdataTable);
            this.Name = "ListUsersForm";
            this.Text = "ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.userdataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userdataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox permissionInput;
        private System.Windows.Forms.Button addPermissionButton;
    }
}