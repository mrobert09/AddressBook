﻿using AddressBookLibrary.DataAccess;
using AddressBookLibrary;
using AddressBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AddressBookUI
{
    public partial class EditEntryForm : Form
    {
        public string passedName;  // receives name from AddressBookViewer

        public EditEntryForm()
        {
            InitializeComponent();
        }

        private void EditEntryForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = passedName;
            var variables = GlobalConfig.Connection.GetAddress(passedName);
            if (variables != null)
            {
                StreetTextBox.Text = variables.street;
                CityTextBox.Text = variables.city;
                StateComboBox.Text = variables.state;
                ZipTextBox.Text = variables.zip;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EntryModel entry = new EntryModel
                {
                    Name = NameTextBox.Text,
                    Address = new AddressModel(StreetTextBox.Text, CityTextBox.Text, StateComboBox.Text, ZipTextBox.Text),
                    PhoneNumbers = ParsePhoneNumbers()
                };

                GlobalConfig.Connection.SaveEntry(entry);

            }
            else
            {

            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if(NameTextBox.Text.Length <= 1)
            {
                output = false;
            }

            return output;
        }


        private List<PhoneNumberModel> ParsePhoneNumbers()
        {
            List<PhoneNumberModel> numbers = new List<PhoneNumberModel>();

            if(HomeTextBox.Text.Length > 0) {
                numbers.Add(new PhoneNumberModel("Home", HomeTextBox.Text));
            }
            if(MobileTextBox.Text.Length > 0)
            {
                numbers.Add(new PhoneNumberModel("Mobile", MobileTextBox.Text));
            }
            if (WorkTextBox.Text.Length > 0)
            {
                numbers.Add(new PhoneNumberModel("Work", WorkTextBox.Text));
            }

            if(numbers.Count > 0)
            {
                return numbers;
            } else { return null; }
        }
    }
}
