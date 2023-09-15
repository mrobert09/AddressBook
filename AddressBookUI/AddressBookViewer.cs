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

namespace AddressBookUI
{
    public partial class AddressBookViewer : Form
    {
        public AddressBookViewer()
        {
            InitializeComponent();

            List<String> names = GlobalConfig.Connection.GetEntries();

            foreach (string name in names)
            {
                AddressListBox.Items.Add(name);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
