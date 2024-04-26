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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
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
        /// Список объектов класса Item
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Св-во поля _items
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                UppdateListBox(value);
                _items = value;
            }
        }

        /// <summary>
        /// Метод который добавляет элементы из списка в листбокс
        /// </summary>
        /// <param name="newItems">_items</param>
        public void UppdateListBox(List<Item> newItems)
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.SelectedIndex = -1;
            ClearInputs();
            for (int i = 0; i < newItems.Count; i++)
            {
                ItemsListBox.Items.Add(newItems[i].Name);
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
            // Инициализация Комбобокса категорий
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        //Добавляет объект в список
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Валидация
            if (NameTextBox.BackColor != WrongInputColor && DescriptionTextBox.BackColor != WrongInputColor && CostTextBox.BackColor != WrongInputColor)
            {
                //Стоимость
                double bufferCost = double.Parse(CostTextBox.Text);
     
                if (ItemsListBox.SelectedIndex != -1)
                {
                    //Выбранный объект
                    Item selectedItem = (Item)ItemsListBox.SelectedItem;
                    int index = ItemsListBox.SelectedIndex;
                    //Изменение выбранного объекта
                    selectedItem.Cost = bufferCost;
                    selectedItem.Name = NameTextBox.Text;
                    selectedItem.Info = DescriptionTextBox.Text;
                    ItemsListBox.Items[index] = selectedItem;
                }
                else
                {
                    //Создание нового объекта
                    Item newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, bufferCost, (Category)CategoryComboBox.SelectedIndex);
                    ItemsListBox.Items.Add(newItem);
                    Items.Add(newItem);
                }
            }
        }

        //Изменение имени с валидацией
        private void NameTextBox_Change(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && NameTextBox.Text.Length  <= 200)
            {
                NameTextBox.BackColor = RightInputColor;
            }
            else
            {
                NameTextBox.BackColor = WrongInputColor;
            }
        
        }

        //Изменение описания с валидацией
        private void DescriptionTextBox_Change(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length > 0 && DescriptionTextBox.Text.Length <= 1000)
            {
                DescriptionTextBox.BackColor = RightInputColor;
            }
            else
            {
                DescriptionTextBox.BackColor = WrongInputColor;
            }

        }

        //Изменение стоимости с валидациейй
        private void CostTexBox_Change(object sender, EventArgs e)
        {
            float bufferCost;
            if (float.TryParse(CostTextBox.Text, out bufferCost))
            {
                if (bufferCost > 0 && bufferCost <= 100000)
                {
                    CostTextBox.BackColor = RightInputColor;
                }
                else
                {
                CostTextBox.BackColor = WrongInputColor;
                }
            }
            else
            {
                CostTextBox.BackColor = WrongInputColor;
            }

        }

        //Чистка
        private void ClearInputs()
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CostTextBox.Text = "";
        }

        //Выбор объекта
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                //Заполнение полей
                IDTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                DescriptionTextBox.Text = selectedItem.Info;
                CostTextBox.Text = selectedItem.Cost.ToString();
                CategoryComboBox.SelectedIndex = (int)selectedItem.Category;
            }
        }

        //Удаляет объект
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                ItemsListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        //Сброс выделения при нажатии клавиши в окне ItemsListBox
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }

        //Сброс выделения при нажатии пкм
        private void ItemsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ItemsListBox.SelectedIndex = -1;
            }
        }
    }
}
