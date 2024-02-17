using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {

        private List<Customer> customers = new List<Customer>();
        private string _fullname;
        private string _address;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressTextBox.Text = "";
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FullnameTextBox.BackColor != Color.Red && AddressTextBox.BackColor != Color.Red)
            {
                Customer newCustomer = new Customer(_fullname, _address);
                if (CustomersListBox.SelectedIndex != -1)
                {
                    int index = CustomersListBox.SelectedIndex;
                    CustomersListBox.Items.Add(newCustomer);
                }
                else
                {
                    CustomersListBox.Items.Add(newCustomer);
                }
                ClearInputs();
                CustomersListBox.SelectedIndex = -1;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                CustomersListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        private void AddressTextBox_Leave(object sender, EventArgs e)
        {
            if (AddressTextBox.BackColor != Color.Red)
            {
                _address = AddressTextBox.Text;
            }
            else
            {
                AddressTextBox.Text = _address;
            }
        }

        private void FullNameTexBox_Leave(object sender, EventArgs e)
        {
            if (FullnameTextBox.BackColor != Color.Red)
            {
                _fullname = FullnameTextBox.Text;
            }
            else
            {
                FullnameTextBox.Text = _fullname;
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                IdTextBox.Text = selectedCustomer.Id.ToString();
                FullnameTextBox.Text = selectedCustomer.Fullname;
                AddressTextBox.Text = selectedCustomer.Address;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string parse = FullnameTextBox.Text;
                if (parse.Length > 0 && parse.Length < 200)
                {
                    FullnameTextBox.BackColor = Color.White;
                }
                else
                {
                    FullnameTextBox.BackColor = Color.Red;
                }
            }
            catch
            {
                FullnameTextBox.BackColor = Color.Red;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string parse = AddressTextBox.Text;
                if (parse.Length > 0 && parse.Length < 500)
                {
                    AddressTextBox.BackColor = Color.White;
                }
                else
                {
                    AddressTextBox.BackColor = Color.Red;
                }
            }
            catch
            {
                AddressTextBox.BackColor = Color.Red;
            }
        }

    }
}
