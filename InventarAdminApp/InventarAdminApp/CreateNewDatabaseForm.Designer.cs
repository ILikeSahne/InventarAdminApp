﻿
namespace InventarAdminApp
{
    partial class CreateNewDatabaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseNameInput = new System.Windows.Forms.TextBox();
            this.adminEmailInput = new System.Windows.Forms.TextBox();
            this.adminPasswordInput = new System.Windows.Forms.TextBox();
            this.adminUsernameInput = new System.Windows.Forms.TextBox();
            this._sendDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin Password";
            // 
            // databaseNameInput
            // 
            this.databaseNameInput.Location = new System.Drawing.Point(103, 10);
            this.databaseNameInput.Name = "databaseNameInput";
            this.databaseNameInput.Size = new System.Drawing.Size(142, 20);
            this.databaseNameInput.TabIndex = 4;
            this.databaseNameInput.Text = "UwUUwU";
            // 
            // adminEmailInput
            // 
            this.adminEmailInput.Location = new System.Drawing.Point(103, 36);
            this.adminEmailInput.Name = "adminEmailInput";
            this.adminEmailInput.Size = new System.Drawing.Size(142, 20);
            this.adminEmailInput.TabIndex = 5;
            this.adminEmailInput.Text = "UwUUwU@gmx.at";
            // 
            // adminPasswordInput
            // 
            this.adminPasswordInput.Location = new System.Drawing.Point(103, 88);
            this.adminPasswordInput.Name = "adminPasswordInput";
            this.adminPasswordInput.PasswordChar = '*';
            this.adminPasswordInput.Size = new System.Drawing.Size(142, 20);
            this.adminPasswordInput.TabIndex = 6;
            this.adminPasswordInput.Text = "UwU123!!";
            // 
            // adminUsernameInput
            // 
            this.adminUsernameInput.Location = new System.Drawing.Point(103, 62);
            this.adminUsernameInput.Name = "adminUsernameInput";
            this.adminUsernameInput.Size = new System.Drawing.Size(142, 20);
            this.adminUsernameInput.TabIndex = 7;
            this.adminUsernameInput.Text = "UwUUwU";
            // 
            // _sendDataButton
            // 
            this._sendDataButton.Location = new System.Drawing.Point(13, 121);
            this._sendDataButton.Name = "_sendDataButton";
            this._sendDataButton.Size = new System.Drawing.Size(232, 23);
            this._sendDataButton.TabIndex = 8;
            this._sendDataButton.Text = "Send Data";
            this._sendDataButton.UseVisualStyleBackColor = true;
            this._sendDataButton.Click += new System.EventHandler(this._sendDataButton_Click);
            // 
            // CreateNewDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 156);
            this.Controls.Add(this._sendDataButton);
            this.Controls.Add(this.adminUsernameInput);
            this.Controls.Add(this.adminPasswordInput);
            this.Controls.Add(this.adminEmailInput);
            this.Controls.Add(this.databaseNameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewDatabaseForm";
            this.Text = "InputDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databaseNameInput;
        private System.Windows.Forms.TextBox adminEmailInput;
        private System.Windows.Forms.TextBox adminPasswordInput;
        private System.Windows.Forms.TextBox adminUsernameInput;
        private System.Windows.Forms.Button _sendDataButton;
    }
}