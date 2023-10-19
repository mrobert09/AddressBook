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
using System.Xml.Linq;

namespace AddressBookUI
{
    public partial class AddressBookViewer : Form
    {
        private List<String> names = new List<String>();

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
            FetchListFromDatabase();
            RefreshList();
        }
        
        /// <summary>
        /// Refreshes the AddressListBox entries.
        /// </summary>
        public void RefreshList()
        {
            AddressListBox.Items.Clear();
            foreach (string name in names)
            {
                AddressListBox.Items.Add(name);
            }
        }

        public void FetchListFromDatabase()
        {
            GlobalConfig.Connection.DeleteUnusedData();
            names =  GlobalConfig.Connection.GetEntries(SearchTextBox.Text);
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
                // Passes empty string to show no items were selected
                passedName = "",
                // Passes reference to this window to edit window
                viewer = this
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
                    passedName = AddressListBox.SelectedItems[0].ToString(),
                    // Passes reference to this window to edit window
                    viewer = this
                };
                editEntryForm.ShowDialog();
            }
        }

        /// <summary>
        /// Method that runs when the 'Delete' button is pressed. Calls the interface method used to 
        /// handle deleting of data and refreshes combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Grabs selected item in AddressListBox
            if (AddressListBox.SelectedItems.Count != 1)
            {
                return;
            }
            else
            {
                GlobalConfig.Connection.DeleteEntry(AddressListBox.SelectedItems[0].ToString(), true);
                names.Remove(AddressListBox.SelectedItems[0].ToString());
                AddressListBox.Items.Remove(AddressListBox.SelectedItems[0].ToString());
                RefreshList();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FetchListFromDatabase();
            RefreshList();
        }
    }
}
