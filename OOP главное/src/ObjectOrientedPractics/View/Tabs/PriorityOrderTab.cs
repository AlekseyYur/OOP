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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrderTab : UserControl
    {
        private PriorityOrder _order;

        public PriorityOrder Order
        {
            set { _order = value; }
            get { return _order; }
        }

        /// <summary>
        /// Обновление страницы
        /// </summary>
        public void UpdatePage()
        {
            //Обновление вещей
            OrderItemsListBox.Items.Clear();
            if (Order.Items != null)
            {
                foreach (var item in Order.Items)
                {
                    OrderItemsListBox.Items.Add(item);
                }
            }
            IdTextBox.Text = Order.Id.ToString();
            CreatedTextBox.Text = Order.Date.ToString();
        }


        //Добавление элемента в заказ
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                OrderItemsListBox.Items.Add((Item)OrderItemsListBox.SelectedItem);
                Order.Items.Add((Item)OrderItemsListBox.SelectedItem);
            }
        }

        //Удаление элемента из заказа
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex != -1)
            {
                OrderItemsListBox.Items.Remove((Item)OrderItemsListBox.SelectedItem);
                Order.Items.Remove((Item)OrderItemsListBox.SelectedItem);
            }
        }

        //Очистка заказа
        private void ClearButton_Click(object sender, EventArgs e)
        {

            OrderItemsListBox.Items.Clear();
            Order = new PriorityOrder();
            UpdatePage();

        }

        public PriorityOrderTab()
        {
            InitializeComponent();
        }

        private void DeliveryTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
