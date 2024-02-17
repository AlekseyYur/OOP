using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemsTab itemsTab = new ItemsTab();
            itemsTab.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(itemsTab);

            CustomersTab customersTab = new CustomersTab();
            customersTab.Dock = DockStyle.Fill;
            tabControl1.TabPages[1].Controls.Add(customersTab);
        }
    }
}