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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            streetTextBox = new TextBox();
            streetLabel = new Label();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            stateLabel = new Label();
            stateComboBox = new ComboBox();
            zipcodeLabel = new Label();
            zipcodeTextBox = new TextBox();
            textBox1 = new TextBox();
            workLabel = new Label();
            textBox2 = new TextBox();
            mobileLabel = new Label();
            textBox3 = new TextBox();
            homeLabel = new Label();
            phoneLabel = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(41, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(100, 28);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(276, 23);
            nameTextBox.TabIndex = 1;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(100, 71);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(276, 23);
            streetTextBox.TabIndex = 3;
            // 
            // streetLabel
            // 
            streetLabel.Location = new Point(41, 74);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(50, 15);
            streetLabel.TabIndex = 2;
            streetLabel.Text = "Street";
            streetLabel.TextAlign = ContentAlignment.MiddleRight;
            streetLabel.Click += label2_Click;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(100, 115);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(276, 23);
            cityTextBox.TabIndex = 5;
            // 
            // cityLabel
            // 
            cityLabel.Location = new Point(41, 118);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(50, 15);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City";
            cityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stateLabel
            // 
            stateLabel.Location = new Point(41, 163);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(50, 15);
            stateLabel.TabIndex = 6;
            stateLabel.Text = "State";
            stateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            stateComboBox.Location = new Point(100, 160);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(59, 23);
            stateComboBox.TabIndex = 7;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.Location = new Point(211, 163);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(50, 15);
            zipcodeLabel.TabIndex = 8;
            zipcodeLabel.Text = "Zipcode";
            zipcodeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.Location = new Point(267, 160);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(109, 23);
            zipcodeTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 339);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 15;
            // 
            // workLabel
            // 
            workLabel.Location = new Point(41, 342);
            workLabel.Name = "workLabel";
            workLabel.Size = new Size(50, 15);
            workLabel.TabIndex = 14;
            workLabel.Text = "Work";
            workLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 23);
            textBox2.TabIndex = 13;
            // 
            // mobileLabel
            // 
            mobileLabel.Location = new Point(41, 298);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new Size(50, 15);
            mobileLabel.TabIndex = 12;
            mobileLabel.Text = "Mobile";
            mobileLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 23);
            textBox3.TabIndex = 11;
            // 
            // homeLabel
            // 
            homeLabel.Location = new Point(41, 255);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(50, 15);
            homeLabel.TabIndex = 10;
            homeLabel.Text = "Home";
            homeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(179, 229);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(93, 15);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Phone Numbers";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(136, 389);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(172, 41);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // EditEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 455);
            Controls.Add(saveButton);
            Controls.Add(phoneLabel);
            Controls.Add(textBox1);
            Controls.Add(workLabel);
            Controls.Add(textBox2);
            Controls.Add(mobileLabel);
            Controls.Add(textBox3);
            Controls.Add(homeLabel);
            Controls.Add(zipcodeTextBox);
            Controls.Add(zipcodeLabel);
            Controls.Add(stateComboBox);
            Controls.Add(stateLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(streetTextBox);
            Controls.Add(streetLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "EditEntryForm";
            Text = "Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox streetTextBox;
        private Label streetLabel;
        private TextBox cityTextBox;
        private Label cityLabel;
        private Label stateLabel;
        private ComboBox stateComboBox;
        private Label zipcodeLabel;
        private TextBox zipcodeTextBox;
        private TextBox textBox1;
        private Label workLabel;
        private TextBox textBox2;
        private Label mobileLabel;
        private TextBox textBox3;
        private Label homeLabel;
        private Label phoneLabel;
        private Button saveButton;
    }
}