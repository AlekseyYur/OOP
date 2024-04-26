using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            ItemsTab itemsTab = new ItemsTab();
            CustomersTab customersTab = new CustomersTab();

            itemsTab.Items = _store.Items;
            customersTab.Customer = _store.Customer;
        }

        private void MainTabControl_TabIndexChanged(object sender, System.EventArgs e)
        {
            cartsTab1.Items = itemsTab1.Items;
            cartsTab1.Customers = customersTab1.Customer;
            ordersTab1.Customers = customersTab1.Customer;
            cartsTab1.RefreshData();
            if (tabControl1.SelectedIndex == 3)
            {
                ordersTab1.RefreshData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ordersTab1_Load(object sender, EventArgs e)
        {

        }
    }
}
