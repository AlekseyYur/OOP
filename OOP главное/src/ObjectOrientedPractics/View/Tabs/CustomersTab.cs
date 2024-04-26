using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Цвет <see cref="TextBox"/>, успешно прошедшего валидацию. 
        /// </summary>
        private Color RightInputColor { get; } = Color.White;

        /// <summary>
        /// Цвет <see cref="TextBox"/>, неудачно прошедшего валидацию. 
        /// </summary>
        private Color WrongInputColor { get; } = Color.Red;

        /// <summary>
        /// Список объектов класса customer
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Св-во поля _customers
        /// </summary>
        public List<Customer> Customer
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Метод для обновления элементов листбокса
        /// </summary>
        /// <param name="newCustomer">_customers</param>
        public void UppdateListBox(List<Customer> newCustomer)
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.SelectedIndex = -1;
            ClearInputs();
            for (int i = 0;  i < newCustomer.Count; i++)
            {
                CustomersListBox.Items.Add(newCustomer[i].FullName);
            }

        }

        public void ClearInputs()
        {
            FullNameTextBox.Text = " ";
            
        }

        public CustomersTab()
        {
            InitializeComponent();
        }

        //Добавление объекта
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Валидация
            if (FullNameTextBox.BackColor != WrongInputColor)
            {
                //Проверка выделения
                if (CustomersListBox.SelectedIndex != -1)
                {
                    int index = CustomersListBox.SelectedIndex;
                    //Выбраный объект
                    Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                    //Изменение объекта
                    selectedCustomer.FullName = FullNameTextBox.Text;
                    selectedCustomer.Address = AddressControl.Address;
                    selectedCustomer.IsPriority = IsPriorityCheckBox.Checked;
                    CustomersListBox.Items[index] = selectedCustomer;
                    Customer[index] = selectedCustomer;
                }
                else
                {
                    //Добавление нового объекта
                    Customer newCustomer = new Customer(FullNameTextBox.Text, AddressControl.Address, IsPriorityCheckBox.Checked);
                    CustomersListBox.Items.Add(newCustomer);
                    Customer.Add(newCustomer);
                }
            }
        }

        //Удаляет выбранный объект
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                CustomersListBox.Items.RemoveAt(index);
                CustomersListBox.SelectedIndex = -1;
                CustomersListBox_SelectedIndexChanged(sender,e);
            }
        }

        //Изменение имени с валидацией
        private void FullNameTextBox_Change(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 0 && FullNameTextBox.Text.Length <= 200)
            {
                FullNameTextBox.BackColor = Color.White;
            }
            else
            {
                FullNameTextBox.BackColor = Color.Red;
            }

        }


        //Выделение объекта в CustomersListBox
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;
                IDTextBox.Text = selectedCustomer.Id.ToString();
                FullNameTextBox.Text = selectedCustomer.FullName;
                AddressControl.Address = selectedCustomer.Address;
                IsPriorityCheckBox.Checked = selectedCustomer.IsPriority;
            }
            else
            {
                IDTextBox.Text = "";
                FullNameTextBox.Text = "";
                AddressControl.Address = new Address();
                IsPriorityCheckBox.Checked = false;
            }
        }

        //Сброс выделения при нажатии клавиши в окне ItemsListBox
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CustomersListBox.SelectedIndex = -1;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }
    }
}
