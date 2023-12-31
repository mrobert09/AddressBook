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
        public AddressBookViewer viewer;

        public EditEntryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populates the edit UI with information upon loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEntryForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = NameTextBox;
            NameTextBox.Text = passedName;
            NameTextBox.SelectionStart = NameTextBox.Text.Length;

            // Autopopulate known address info
            var addressInfo = GlobalConfig.Connection.GetAddress(passedName);
            if (addressInfo != null)
            {
                StreetTextBox.Text = addressInfo.street;
                CityTextBox.Text = addressInfo.city;
                StateComboBox.Text = addressInfo.state;
                ZipTextBox.Text = addressInfo.zip;
            }

            // Autopopulate known phone info
            var phoneInfo = GlobalConfig.Connection.GetPhoneNumbers(passedName);
            if (phoneInfo != null)
            {
                foreach (var number in phoneInfo)
                {
                    Console.WriteLine(number);
                    if (number.phoneType == 1) { HomeTextBox.Text = number.phoneNumber; } 
                    else if (number.phoneType == 2) {MobileTextBox.Text = number.phoneNumber; }
                    else if (number.phoneType == 3) { WorkTextBox.Text = number.phoneNumber; }
                }
            }
        }

        /// <summary>
        /// Method that runs when the 'Save' button is clicked. Creates an entry object and sends it to the SaveEntry function in the connection class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                GlobalConfig.Connection.SaveEntry(entry, passedName);
                viewer.FetchListFromDatabase();
                viewer.RefreshList();  // refreshes the listbox in AddressBookViewer
                this.Close();
            }
        }

        /// <summary>
        /// Ensures the form has at least a name written in the NameTextBox to be a valid entry.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;

            if(NameTextBox.Text.Length <= 1)
            {
                output = false;
            }

            return output;
        }


        /// <summary>
        /// Checks each phone number box and adds them to a list of phone number models if they are present.
        /// </summary>
        /// <returns>List of phone number models if list has at least 1 member. Returns null of list is empty.</returns>
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
