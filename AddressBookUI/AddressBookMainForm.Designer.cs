namespace AddressBookUI
{
    partial class AddressBookMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entryListBox = new ListBox();
            newButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            fileComboBox = new ComboBox();
            loadButton = new Button();
            SuspendLayout();
            // 
            // entryListBox
            // 
            entryListBox.FormattingEnabled = true;
            entryListBox.ItemHeight = 19;
            entryListBox.Location = new Point(12, 196);
            entryListBox.Name = "entryListBox";
            entryListBox.Size = new Size(524, 270);
            entryListBox.TabIndex = 0;
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 84);
            newButton.Name = "newButton";
            newButton.Size = new Size(128, 38);
            newButton.TabIndex = 1;
            newButton.Text = "New Entry";
            newButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(408, 84);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(128, 38);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(213, 84);
            editButton.Name = "editButton";
            editButton.Size = new Size(128, 38);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(12, 162);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(52, 19);
            searchLabel.TabIndex = 4;
            searchLabel.Text = "Search";
            searchLabel.Click += label1_Click_1;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(70, 159);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(466, 27);
            searchTextBox.TabIndex = 5;
            // 
            // fileComboBox
            // 
            fileComboBox.FormattingEnabled = true;
            fileComboBox.Location = new Point(12, 21);
            fileComboBox.Name = "fileComboBox";
            fileComboBox.Size = new Size(329, 27);
            fileComboBox.TabIndex = 6;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(408, 14);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(128, 38);
            loadButton.TabIndex = 7;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // AddressBookMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(547, 477);
            Controls.Add(loadButton);
            Controls.Add(fileComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(newButton);
            Controls.Add(entryListBox);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddressBookMainForm";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox entryListBox;
        private Button newButton;
        private Button deleteButton;
        private Button editButton;
        private Label searchLabel;
        private TextBox searchTextBox;
        private ComboBox fileComboBox;
        private Button loadButton;
    }
}