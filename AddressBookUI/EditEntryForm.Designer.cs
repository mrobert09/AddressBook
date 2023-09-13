namespace AddressBookUI
{
    partial class EditEntryForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.HomeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.WorkTextBox = new System.Windows.Forms.TextBox();
            this.WorkLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TagLabel = new System.Windows.Forms.Label();
            this.TagInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(126, 441);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 32);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(18, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 18);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StreetLabel
            // 
            this.StreetLabel.Location = new System.Drawing.Point(18, 95);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(50, 18);
            this.StreetLabel.TabIndex = 2;
            this.StreetLabel.Text = "Street";
            this.StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(18, 127);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(50, 18);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "City";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateLabel
            // 
            this.StateLabel.Location = new System.Drawing.Point(18, 159);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(50, 18);
            this.StateLabel.TabIndex = 4;
            this.StateLabel.Text = "State";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Location = new System.Drawing.Point(135, 159);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(50, 18);
            this.ZipLabel.TabIndex = 5;
            this.ZipLabel.Text = "Zip";
            this.ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(74, 24);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(203, 26);
            this.NameTextBox.TabIndex = 6;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(74, 92);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(203, 26);
            this.StreetTextBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(74, 124);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(203, 26);
            this.CityTextBox.TabIndex = 8;
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox.Location = new System.Drawing.Point(74, 156);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(55, 26);
            this.StateComboBox.TabIndex = 9;
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(191, 156);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(86, 26);
            this.ZipTextBox.TabIndex = 10;
            // 
            // HomeLabel
            // 
            this.HomeLabel.Location = new System.Drawing.Point(18, 240);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(50, 18);
            this.HomeLabel.TabIndex = 11;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(123, 71);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(78, 18);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeTextBox
            // 
            this.HomeTextBox.Location = new System.Drawing.Point(74, 237);
            this.HomeTextBox.Name = "HomeTextBox";
            this.HomeTextBox.Size = new System.Drawing.Size(203, 26);
            this.HomeTextBox.TabIndex = 13;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(123, 216);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(78, 18);
            this.PhoneLabel.TabIndex = 14;
            this.PhoneLabel.Text = "Phone";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(74, 269);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(203, 26);
            this.MobileTextBox.TabIndex = 16;
            // 
            // MobileLabel
            // 
            this.MobileLabel.Location = new System.Drawing.Point(12, 272);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(56, 18);
            this.MobileLabel.TabIndex = 15;
            this.MobileLabel.Text = "Mobile";
            this.MobileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkTextBox
            // 
            this.WorkTextBox.Location = new System.Drawing.Point(74, 301);
            this.WorkTextBox.Name = "WorkTextBox";
            this.WorkTextBox.Size = new System.Drawing.Size(203, 26);
            this.WorkTextBox.TabIndex = 18;
            // 
            // WorkLabel
            // 
            this.WorkLabel.Location = new System.Drawing.Point(18, 304);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new System.Drawing.Size(50, 18);
            this.WorkLabel.TabIndex = 17;
            this.WorkLabel.Text = "Work";
            this.WorkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 26);
            this.textBox3.TabIndex = 20;
            // 
            // TagLabel
            // 
            this.TagLabel.Location = new System.Drawing.Point(18, 373);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(50, 18);
            this.TagLabel.TabIndex = 19;
            this.TagLabel.Text = "Tags";
            this.TagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TagInfoLabel
            // 
            this.TagInfoLabel.Location = new System.Drawing.Point(80, 399);
            this.TagInfoLabel.Name = "TagInfoLabel";
            this.TagInfoLabel.Size = new System.Drawing.Size(174, 18);
            this.TagInfoLabel.TabIndex = 21;
            this.TagInfoLabel.Text = "(comma separated)";
            this.TagInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 486);
            this.Controls.Add(this.TagInfoLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.WorkTextBox);
            this.Controls.Add(this.WorkLabel);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.MobileLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.HomeTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.ZipTextBox);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditEntryForm";
            this.Text = "Edit Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox HomeTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.TextBox WorkTextBox;
        private System.Windows.Forms.Label WorkLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Label TagInfoLabel;
    }
}