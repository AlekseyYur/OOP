using ObjectOrientedPractics.View.Forms;
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
using ObjectOrientedPractics.Model.Discounts;
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
        /// Удалённые скидки
        /// </summary>
        private List<IDiscount> _deletingDisconts = new List<IDiscount>();

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
        /// Обновляет данные в списке скидок покупателя.
        /// </summary>
        public void UpdateDiscountsListBox()
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                return;
            }

            UpdateDiscountsListBox(Customer[CustomersListBox.SelectedIndex]);
        }


        /// <summary>
        /// Обновляет данные в списке скидок покупателя.
        /// </summary>
        /// <param name="customer">Текущий покупатель.</param>
        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
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

                    //Удаление лишних скидок
                    foreach (var discont in _deletingDisconts)
                    {
                        selectedCustomer.Discounts.Remove(discont);
                    }
                    _deletingDisconts.Clear();

                    //Добавление новых скидок
                    for (int i = 0; i < DiscountsListBox.Items.Count; i++)
                    {
                        IDiscount discount = (IDiscount)DiscountsListBox.Items[i];
                        if (!selectedCustomer.Discounts.Contains(discount))
                        {
                            selectedCustomer.Discounts.Add(discount);
                        }
                    }

                    CustomersListBox.Items[index] = selectedCustomer;
                    Customer[index] = selectedCustomer;
                    
                }
                else
                {
                    //Добавление нового объекта
                    Customer newCustomer = new Customer(FullNameTextBox.Text, AddressControl.Address, IsPriorityCheckBox.Checked);

                    //Добавление скидок
                    for (int i = 0; i < DiscountsListBox.Items.Count; i++)
                    {
                        IDiscount discount = (IDiscount)DiscountsListBox.Items[i];
                        newCustomer.Discounts.Add(discount);
                    }

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
                Customer.RemoveAt(index);
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

                foreach (IDiscount discount in selectedCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount);
                }
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

        private void ItemsSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Добавление скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountsButton_Click(object sender, EventArgs e)
        {
            AddDiscount newDiscount = new AddDiscount(Customer[CustomersListBox.SelectedIndex]);
            newDiscount.ShowDialog();
            if (newDiscount.confirm == true)
            {
                var discount = new PercentDiscounts(newDiscount.Category);
                Customer[CustomersListBox.SelectedIndex].Discounts.Add(discount);
                UpdateDiscountsListBox(Customer[CustomersListBox.SelectedIndex]);
                //DiscountsListBox.Items.Add(new PercentDiscounts(newDiscount.Category));
            }
        }

        /// <summary>
        /// Удаление скидки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDiscountsButton_Click(object sender, EventArgs e)
        {
            var removedIndex = DiscountsListBox.SelectedIndex;
            Customer[CustomersListBox.SelectedIndex].Discounts.RemoveAt(
                DiscountsListBox.SelectedIndex);
            UpdateDiscountsListBox(Customer[CustomersListBox.SelectedIndex]);

            if (removedIndex >= DiscountsListBox.Items.Count)
            {
                DiscountsListBox.SelectedIndex = removedIndex - 1;
            }
            else
            {
                DiscountsListBox.SelectedIndex = removedIndex;
            }
            /*if (DiscountsListBox.SelectedIndex > 0)
            {
                if (CustomersListBox.SelectedIndex != -1)
                {
                    _deletingDisconts.Add((IDiscount)DiscountsListBox.SelectedItem);
                }
                DiscountsListBox.Items.Remove(DiscountsListBox.SelectedItem);
            }*/
        }


    }
}
