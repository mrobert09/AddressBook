using AddressBookLibrary.DataAccess;
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
        public EditEntryForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EntryModel entry = new EntryModel();

                entry.Name = NameTextBox.Text;
                entry.Address = new AddressModel(StreetTextBox.Text, CityTextBox.Text, StateComboBox.Text, ZipTextBox.Text);
                entry.PhoneNumbers = ParsePhoneNumbers();

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.SaveEntry(entry);
                }
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
