
namespace InventarAdminApp
{
    partial class AddNewItemForm
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
            this.aktuelleNummerInput = new System.Windows.Forms.TextBox();
            this.unternummerInput = new System.Windows.Forms.TextBox();
            this.anlageInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aktivirungAmInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.serialNummerInput = new System.Windows.Forms.TextBox();
            this.anschaffWertInput = new System.Windows.Forms.NumericUpDown();
            this.buchWertInput = new System.Windows.Forms.NumericUpDown();
            this.waehrungInput = new System.Windows.Forms.TextBox();
            this.kfzKennzeichenInput = new System.Windows.Forms.TextBox();
            this.raumInput = new System.Windows.Forms.TextBox();
            this.raumBezeichungInput = new System.Windows.Forms.TextBox();
            this.anlagenBezeichnungInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.notizInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.permissionInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anschaffWertInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchWertInput)).BeginInit();
            this.SuspendLayout();
            // 
            // _sendDataButton
            // 
            this._sendDataButton.Location = new System.Drawing.Point(13, 623);
            this._sendDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._sendDataButton.Name = "_sendDataButton";
            this._sendDataButton.Size = new System.Drawing.Size(348, 35);
            this._sendDataButton.TabIndex = 17;
            this._sendDataButton.Text = "Send Data";
            this._sendDataButton.UseVisualStyleBackColor = true;
            this._sendDataButton.Click += new System.EventHandler(this._sendDataButton_Click);
            // 
            // aktuelleNummerInput
            // 
            this.aktuelleNummerInput.Location = new System.Drawing.Point(156, 97);
            this.aktuelleNummerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aktuelleNummerInput.Name = "aktuelleNummerInput";
            this.aktuelleNummerInput.Size = new System.Drawing.Size(211, 26);
            this.aktuelleNummerInput.TabIndex = 16;
            this.aktuelleNummerInput.Text = "105-00/2008/01";
            // 
            // unternummerInput
            // 
            this.unternummerInput.Location = new System.Drawing.Point(156, 57);
            this.unternummerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unternummerInput.Name = "unternummerInput";
            this.unternummerInput.Size = new System.Drawing.Size(211, 26);
            this.unternummerInput.TabIndex = 14;
            this.unternummerInput.Text = "0";
            // 
            // anlageInput
            // 
            this.anlageInput.Location = new System.Drawing.Point(156, 17);
            this.anlageInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anlageInput.Name = "anlageInput";
            this.anlageInput.Size = new System.Drawing.Size(211, 26);
            this.anlageInput.TabIndex = 13;
            this.anlageInput.Text = "312002794672";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aktivierung Am";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aktuelle Nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Unternummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Anlage";
            // 
            // aktivirungAmInput
            // 
            this.aktivirungAmInput.CustomFormat = "DD/MM/YYYY";
            this.aktivirungAmInput.Location = new System.Drawing.Point(156, 137);
            this.aktivirungAmInput.Name = "aktivirungAmInput";
            this.aktivirungAmInput.Size = new System.Drawing.Size(211, 26);
            this.aktivirungAmInput.TabIndex = 18;
            this.aktivirungAmInput.Value = new System.DateTime(2008, 9, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Buch Wert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Anschaff Wert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Serialnummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 462);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Raum Bez.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 422);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Raum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 382);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Kfz Kennzeichen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 342);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Währung";
            // 
            // serialNummerInput
            // 
            this.serialNummerInput.Location = new System.Drawing.Point(156, 219);
            this.serialNummerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serialNummerInput.Name = "serialNummerInput";
            this.serialNummerInput.Size = new System.Drawing.Size(211, 26);
            this.serialNummerInput.TabIndex = 28;
            // 
            // anschaffWertInput
            // 
            this.anschaffWertInput.DecimalPlaces = 2;
            this.anschaffWertInput.Location = new System.Drawing.Point(156, 260);
            this.anschaffWertInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.anschaffWertInput.Name = "anschaffWertInput";
            this.anschaffWertInput.Size = new System.Drawing.Size(211, 26);
            this.anschaffWertInput.TabIndex = 29;
            this.anschaffWertInput.Value = new decimal(new int[] {
            200861,
            0,
            0,
            131072});
            // 
            // buchWertInput
            // 
            this.buchWertInput.DecimalPlaces = 2;
            this.buchWertInput.Location = new System.Drawing.Point(156, 300);
            this.buchWertInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.buchWertInput.Name = "buchWertInput";
            this.buchWertInput.Size = new System.Drawing.Size(211, 26);
            this.buchWertInput.TabIndex = 30;
            // 
            // waehrungInput
            // 
            this.waehrungInput.Location = new System.Drawing.Point(156, 339);
            this.waehrungInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.waehrungInput.Name = "waehrungInput";
            this.waehrungInput.Size = new System.Drawing.Size(211, 26);
            this.waehrungInput.TabIndex = 31;
            this.waehrungInput.Text = "EUR";
            // 
            // kfzKennzeichenInput
            // 
            this.kfzKennzeichenInput.Location = new System.Drawing.Point(156, 379);
            this.kfzKennzeichenInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kfzKennzeichenInput.Name = "kfzKennzeichenInput";
            this.kfzKennzeichenInput.Size = new System.Drawing.Size(211, 26);
            this.kfzKennzeichenInput.TabIndex = 32;
            this.kfzKennzeichenInput.Text = "065";
            // 
            // raumInput
            // 
            this.raumInput.Location = new System.Drawing.Point(156, 419);
            this.raumInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.raumInput.Name = "raumInput";
            this.raumInput.Size = new System.Drawing.Size(211, 26);
            this.raumInput.TabIndex = 33;
            this.raumInput.Text = "BT8/1-55";
            // 
            // raumBezeichungInput
            // 
            this.raumBezeichungInput.Location = new System.Drawing.Point(156, 459);
            this.raumBezeichungInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.raumBezeichungInput.Name = "raumBezeichungInput";
            this.raumBezeichungInput.Size = new System.Drawing.Size(211, 26);
            this.raumBezeichungInput.TabIndex = 34;
            this.raumBezeichungInput.Text = "Bauteil 8 Lehrsaal 813B";
            // 
            // anlagenBezeichnungInput
            // 
            this.anlagenBezeichnungInput.Location = new System.Drawing.Point(156, 177);
            this.anlagenBezeichnungInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anlagenBezeichnungInput.Name = "anlagenBezeichnungInput";
            this.anlagenBezeichnungInput.Size = new System.Drawing.Size(211, 26);
            this.anlagenBezeichnungInput.TabIndex = 36;
            this.anlagenBezeichnungInput.Text = "Labortisch für CAN-System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Anlagenbez.";
            // 
            // statusInput
            // 
            this.statusInput.Location = new System.Drawing.Point(156, 495);
            this.statusInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusInput.Name = "statusInput";
            this.statusInput.Size = new System.Drawing.Size(211, 26);
            this.statusInput.TabIndex = 38;
            this.statusInput.Text = "Vorhanden";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 498);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Status";
            // 
            // notizInput
            // 
            this.notizInput.Location = new System.Drawing.Point(156, 531);
            this.notizInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.notizInput.Name = "notizInput";
            this.notizInput.Size = new System.Drawing.Size(211, 26);
            this.notizInput.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 534);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Notiz";
            // 
            // permissionInput
            // 
            this.permissionInput.Location = new System.Drawing.Point(156, 567);
            this.permissionInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permissionInput.Name = "permissionInput";
            this.permissionInput.Size = new System.Drawing.Size(211, 26);
            this.permissionInput.TabIndex = 42;
            this.permissionInput.Text = "admin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 570);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Permission";
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 672);
            this.Controls.Add(this.permissionInput);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.notizInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.statusInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.anlagenBezeichnungInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.raumBezeichungInput);
            this.Controls.Add(this.raumInput);
            this.Controls.Add(this.kfzKennzeichenInput);
            this.Controls.Add(this.waehrungInput);
            this.Controls.Add(this.buchWertInput);
            this.Controls.Add(this.anschaffWertInput);
            this.Controls.Add(this.serialNummerInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aktivirungAmInput);
            this.Controls.Add(this._sendDataButton);
            this.Controls.Add(this.aktuelleNummerInput);
            this.Controls.Add(this.unternummerInput);
            this.Controls.Add(this.anlageInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewItemForm";
            this.Text = "AddNewItem";
            ((System.ComponentModel.ISupportInitialize)(this.anschaffWertInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buchWertInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sendDataButton;
        private System.Windows.Forms.TextBox aktuelleNummerInput;
        private System.Windows.Forms.TextBox unternummerInput;
        private System.Windows.Forms.TextBox anlageInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker aktivirungAmInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox serialNummerInput;
        private System.Windows.Forms.NumericUpDown anschaffWertInput;
        private System.Windows.Forms.NumericUpDown buchWertInput;
        private System.Windows.Forms.TextBox waehrungInput;
        private System.Windows.Forms.TextBox kfzKennzeichenInput;
        private System.Windows.Forms.TextBox raumInput;
        private System.Windows.Forms.TextBox raumBezeichungInput;
        private System.Windows.Forms.TextBox anlagenBezeichnungInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox notizInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox permissionInput;
        private System.Windows.Forms.Label label15;
    }
}