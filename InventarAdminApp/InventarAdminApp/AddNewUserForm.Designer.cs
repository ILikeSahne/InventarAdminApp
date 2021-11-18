
namespace InventarAdminApp
{
    partial class AddNewUserForm
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
            this._sendDataButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _sendDataButton
            // 
            this._sendDataButton.Location = new System.Drawing.Point(22, 152);
            this._sendDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._sendDataButton.Name = "_sendDataButton";
            this._sendDataButton.Size = new System.Drawing.Size(348, 35);
            this._sendDataButton.TabIndex = 15;
            this._sendDataButton.Text = "Send Data";
            this._sendDataButton.UseVisualStyleBackColor = true;
            this._sendDataButton.Click += new System.EventHandler(this._sendDataButton_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(156, 61);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(211, 26);
            this.usernameInput.TabIndex = 14;
            this.usernameInput.Text = "TestUser2";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(156, 101);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(211, 26);
            this.passwordInput.TabIndex = 13;
            this.passwordInput.Text = "Test123!!!";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(156, 21);
            this.emailInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(211, 26);
            this.emailInput.TabIndex = 12;
            this.emailInput.Text = "Test2@gmx.at";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 208);
            this.Controls.Add(this._sendDataButton);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sendDataButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}