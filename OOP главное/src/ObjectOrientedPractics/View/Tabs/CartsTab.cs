using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;


        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                if (_items != null)
                {
                    UpdateItemsListBox(-1);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.FullName);
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задает выбранного покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        public double DiscountAmount { get; set; }

        /// <summary>
        /// Обновляет данные.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox(-1);

            CustomerComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.FullName);
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                CustomerComboBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Сортирует и обновляет товары.
        /// </summary>
        /// <param name="selectedIndex">Выбраный элемент.</param>
        private void UpdateItemsListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            var orderedListItems = _items.OrderBy(item => item.Name).ToList();

            foreach (Item item in orderedListItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Сортирует и обновляет корзины.
        /// </summary>
        /// <param name="selectedIndex">Выбраный элемент.</param>
        private void UpdateCartListBox(int selectedIndex)
        {
            CartListBox.Items.Clear();

            var orderedListItems = CurrentCustomer.Cart.Items.OrderBy(item => item.Name).ToList();

            foreach (Item item in orderedListItems)
            {
                CartListBox.Items.Add(item.Name);
            }

            CartListBox.SelectedIndex = selectedIndex;

            CreateOrderButton.Enabled = false;

            UpdateAmountLabels();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = CustomerComboBox.SelectedIndex;

            if (index == -1)
            {
                return;
            }
            else
            {
                CurrentCustomer = _customers[index];

                if (CurrentCustomer.Cart.Items == null)
                {
                    return;
                }
                else
                {
                    AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                    UpdateDiscountsCheckedListBox();
                    UpdateCartListBox(-1);
                }
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int indexListBox = ItemsListBox.SelectedIndex;
            int indexComboBox = CustomerComboBox.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1)
            {
                return;
            }
            else
            {
                CurrentCustomer.Cart.Items.Add(_items[indexListBox]);

                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                UpdateCartListBox(-1);
                CreateOrderButton.Enabled = true;
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int indexComboBox = CustomerComboBox.SelectedIndex;
            int indexListBox = CartListBox.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1)
            {
                return;
            }
            else
            {
                CurrentCustomer.Cart.Items.RemoveAt(indexListBox);
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                UpdateCartListBox(-1);
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart = new Cart();
            UpdateCartListBox(-1);
            AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null || CartListBox.Items.Count == 0)
            {
                return;
            }


            var items = new List<Item>();
            Order order;

            foreach (var item in CurrentCustomer.Cart.Items)
            {
                items.Add(item);
            }
            
            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder(OrderStatus.New, CurrentCustomer.Address, items);
                CurrentCustomer.Orders.Add(order);
                CurrentCustomer.Cart.Items.Clear();
            }
            else
            {

            order = new Order(OrderStatus.New, CurrentCustomer.Address, items);
            UpdateCustomerDiscounts(items);
            UpdateDiscountsCheckedListBox();
            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart.Items.Clear();
            }
        }

        /// <summary>
        /// Обновляет данные списка скидок <see cref="DiscountsCheckedListBox"/>. 
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            if (Customers.Count == 0)
            {
                DiscountsCheckedListBox.Items.Clear();
                //DiscountsCheckedListBox.Enabled = false;
                return;
            }

            DiscountsCheckedListBox.Items.Clear();

            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info);
            }

            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }

            AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            //DiscountsCheckedListBox.Enabled = true;
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = AmountLabel.Text;
        }

        /// <summary>
        /// Обновляет текстовые данные.
        /// </summary>
        private void UpdateAmountLabels()
        {
            DiscountAmount = 0.0;

            foreach (var item in DiscountsCheckedListBox.CheckedItems)
            {
                var index = DiscountsCheckedListBox.Items.IndexOf(item);
                DiscountAmount += CurrentCustomer.Discounts[index].Calculate(
                    CurrentCustomer.Cart.Items);
            }

            var amount = CurrentCustomer.Cart.Amount;
            AmountLabel.Text = amount.ToString();
            DiscountAmountLabel.Text = DiscountAmount.ToString();
            TotalLabel.Text = (amount - DiscountAmount).ToString();
        }

        /// <summary>
        /// Обновляет скидки покупателя по заданому списку товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        private void UpdateCustomerDiscounts(List<Item> items)
        {
            foreach (var discount in CurrentCustomer.Discounts)
            {
                if (DiscountsCheckedListBox.CheckedItems.Contains(discount.Info))
                {
                    discount.Apply(items);
                }

                discount.Update(items);
            }
        }

        /// <summary>
        /// Событие при изменении выбора или состояния элемента в 
        /// <see cref="DiscountsCheckedListBox"/>.
        /// </summary>
        /// <param name="sender">Элемент управления, вызвавший событие.</param>
        /// <param name="e">Данные о событии.</param>
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateAmountLabels();
        }

    }
}
