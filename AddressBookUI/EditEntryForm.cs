using AddressBookLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookUI
{
    public partial class EditEntryForm : Form
    {
        public EditEntryForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                EntryModel entry = new()
                {
                    Name = nameValue.Text,
                    Address = new AddressModel(streetValue.Text, cityValue.Text, stateValue.Text, zipcodeValue.Text),
                    PhoneNumbers = ParsePhoneNumbers()
                };

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.SaveEntry(entry);
                }
            } else
            {

            }
        }

        private void nameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;

            if (nameValue.Text.Length <= 0)
            {
                output = false;
            }

            return output;
        }

        private List<PhoneNumberModel> ParsePhoneNumbers()
        {
            List<PhoneNumberModel> phoneNumbers = new();

            if (homeValue.Text != null)
            {
                phoneNumbers.Add(new PhoneNumberModel("Home", homeValue.Text));
            }
            if (mobileValue.Text != null)
            {
                phoneNumbers.Add(new PhoneNumberModel("Mobile", mobileValue.Text));
            }
            if (workValue.Text != null)
            {
                phoneNumbers.Add(new PhoneNumberModel("Work", workValue.Text));
            }

            return phoneNumbers;
        }
    }
}
