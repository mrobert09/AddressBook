using AddressBookLibrary.DataAccess;
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
using System.Drawing.Text;

namespace AddressBookUI
{
    public partial class AddressBookViewer : Form
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public AddressBookViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populates the address UI with names upon loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressBookViewer_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AddressListBox;
            List<String> names = GlobalConfig.Connection.GetEntries();

            foreach (string name in names)
            {
                AddressListBox.Items.Add(name);
            }
        }

        /// <summary>
        /// Method that runs when the 'New' button is pressed. Opens a new window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewButton_Click(object sender, EventArgs e)
        {
            EditEntryForm editEntryForm = new EditEntryForm
            {
                passedName = ""
            };
            editEntryForm.ShowDialog();
        }

        /// <summary>
        /// Method that runs when the 'Edit' button is pressed. Opens a new window autopopulated with fetched data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Grabs selected item in AddressListBox
            if (AddressListBox.SelectedItems.Count != 1)
            {
                return;
            } else
            {
                EditEntryForm editEntryForm = new EditEntryForm
                {
                    // Passes the selected item as a string to the new EditEntryForm entity
                    passedName = AddressListBox.SelectedItems[0].ToString()
                };
                editEntryForm.ShowDialog();
            }
        }
    }
}
