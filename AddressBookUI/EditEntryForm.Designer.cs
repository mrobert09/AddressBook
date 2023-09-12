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
            nameValue = new TextBox();
            streetValue = new TextBox();
            streetLabel = new Label();
            cityValue = new TextBox();
            cityLabel = new Label();
            stateLabel = new Label();
            stateValue = new ComboBox();
            zipcodeLabel = new Label();
            zipcodeValue = new TextBox();
            workValue = new TextBox();
            workLabel = new Label();
            mobileValue = new TextBox();
            mobileLabel = new Label();
            homeValue = new TextBox();
            homeLabel = new Label();
            phoneLabel = new Label();
            saveButton = new Button();
            tagLabel = new Label();
            tagValue = new TextBox();
            tagInfoTextBox = new Label();
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
            // nameValue
            // 
            nameValue.Location = new Point(100, 28);
            nameValue.MaxLength = 50;
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(276, 23);
            nameValue.TabIndex = 1;
            nameValue.TextChanged += nameValue_TextChanged;
            // 
            // streetValue
            // 
            streetValue.Location = new Point(100, 71);
            streetValue.MaxLength = 50;
            streetValue.Name = "streetValue";
            streetValue.Size = new Size(276, 23);
            streetValue.TabIndex = 3;
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
            // cityValue
            // 
            cityValue.Location = new Point(100, 115);
            cityValue.MaxLength = 50;
            cityValue.Name = "cityValue";
            cityValue.Size = new Size(276, 23);
            cityValue.TabIndex = 5;
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
            // stateValue
            // 
            stateValue.FormattingEnabled = true;
            stateValue.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            stateValue.Location = new Point(100, 160);
            stateValue.MaxLength = 2;
            stateValue.Name = "stateValue";
            stateValue.Size = new Size(59, 23);
            stateValue.TabIndex = 7;
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
            // zipcodeValue
            // 
            zipcodeValue.Location = new Point(267, 160);
            zipcodeValue.MaxLength = 10;
            zipcodeValue.Name = "zipcodeValue";
            zipcodeValue.Size = new Size(109, 23);
            zipcodeValue.TabIndex = 9;
            // 
            // workValue
            // 
            workValue.Location = new Point(100, 339);
            workValue.MaxLength = 20;
            workValue.Name = "workValue";
            workValue.Size = new Size(276, 23);
            workValue.TabIndex = 15;
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
            // mobileValue
            // 
            mobileValue.Location = new Point(100, 295);
            mobileValue.MaxLength = 20;
            mobileValue.Name = "mobileValue";
            mobileValue.Size = new Size(276, 23);
            mobileValue.TabIndex = 13;
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
            // homeValue
            // 
            homeValue.Location = new Point(100, 252);
            homeValue.MaxLength = 20;
            homeValue.Name = "homeValue";
            homeValue.Size = new Size(276, 23);
            homeValue.TabIndex = 11;
            homeValue.TextChanged += homeValue_TextChanged;
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
            phoneLabel.Location = new Point(178, 234);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(93, 15);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Phone Numbers";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(125, 480);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(172, 41);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // tagLabel
            // 
            tagLabel.AccessibleDescription = "";
            tagLabel.Location = new Point(41, 427);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(50, 15);
            tagLabel.TabIndex = 18;
            tagLabel.Text = "Tags";
            tagLabel.TextAlign = ContentAlignment.MiddleRight;
            tagLabel.Click += label1_Click;
            // 
            // tagValue
            // 
            tagValue.Location = new Point(100, 424);
            tagValue.Name = "tagValue";
            tagValue.Size = new Size(276, 23);
            tagValue.TabIndex = 19;
            // 
            // tagInfoTextBox
            // 
            tagInfoTextBox.AutoSize = true;
            tagInfoTextBox.Location = new Point(161, 450);
            tagInfoTextBox.Name = "tagInfoTextBox";
            tagInfoTextBox.Size = new Size(110, 15);
            tagInfoTextBox.TabIndex = 20;
            tagInfoTextBox.Text = "(comma separated)";
            // 
            // EditEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 530);
            Controls.Add(tagInfoTextBox);
            Controls.Add(tagValue);
            Controls.Add(tagLabel);
            Controls.Add(saveButton);
            Controls.Add(phoneLabel);
            Controls.Add(workValue);
            Controls.Add(workLabel);
            Controls.Add(mobileValue);
            Controls.Add(mobileLabel);
            Controls.Add(homeValue);
            Controls.Add(homeLabel);
            Controls.Add(zipcodeValue);
            Controls.Add(zipcodeLabel);
            Controls.Add(stateValue);
            Controls.Add(stateLabel);
            Controls.Add(cityValue);
            Controls.Add(cityLabel);
            Controls.Add(streetValue);
            Controls.Add(streetLabel);
            Controls.Add(nameValue);
            Controls.Add(nameLabel);
            Name = "EditEntryForm";
            Text = "Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameValue;
        private TextBox streetValue;
        private Label streetLabel;
        private TextBox cityValue;
        private Label cityLabel;
        private Label stateLabel;
        private ComboBox stateValue;
        private Label zipcodeLabel;
        private TextBox zipcodeValue;
        private TextBox workValue;
        private Label workLabel;
        private TextBox mobileValue;
        private Label mobileLabel;
        private TextBox homeValue;
        private Label homeLabel;
        private Label phoneLabel;
        private Button saveButton;
        private Label tagLabel;
        private TextBox tagValue;
        private Label tagInfoTextBox;
    }
}