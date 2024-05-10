using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscount : Form
    {
        //Выбранная категория
        private Category _category;
        //Окно закрыто через Ok
        public bool confirm = false;

        public Customer Customer { get; set; }

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public AddDiscount(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerCategories = new List<Category>();
            foreach (var discount in Customer.Discounts)
            {
                if (discount is PercentDiscounts)
                {
                    var percentDiscount = discount as PercentDiscounts;
                    customerCategories.Add(percentDiscount.Category);
                }
            }

            var dataCategories = new List<Category>();
            foreach (var category in Enum.GetValues(typeof(Category)).Cast<Category>().ToList())
            {
                if (!customerCategories.Contains(category))
                {
                    dataCategories.Add(category);
                }
            }

            CategoryComboBox.DataSource = dataCategories;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            confirm = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
