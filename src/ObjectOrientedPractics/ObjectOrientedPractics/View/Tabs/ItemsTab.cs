using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {

        private List<Item> items = new List<Item>();
        private string _name;
        private string _info;
        private string _cost;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ClearInputs()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            NameTextBox.BackColor = Color.White;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.BackColor = Color.White;
            CostTextBox.Text = "";
            CostTextBox.BackColor = Color.White;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double value;
            if (CostTextBox.BackColor != Color.Red && NameTextBox.BackColor != Color.Red && DescriptionTextBox.BackColor != Color.Red)
            {
                double.TryParse(_cost, out value);
                Item newItem = new Item(_name, _info, value);
                if (ItemsListBox.SelectedIndex != -1)
                {
                    int index = ItemsListBox.SelectedIndex;
                    ItemsListBox.Items[index] = newItem;
                    items[index] = newItem;
                }
                else
                {
                    items.Add(newItem);
                    ItemsListBox.Items.Add(newItem);
                }
                ClearInputs();
                ItemsListBox.SelectedIndex = -1;
            }
            else
            {
                LabelError.Text = "В каком-то из полей у вас ошибка";
            }
            ClearInputs();
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if(NameTextBox.BackColor != Color.Red)
            {
                _name = NameTextBox.Text;
            }
            else
            {
                NameTextBox.Text = _name;
            }
        }

        private void DescriptionTextBox_Leave(Object sender, EventArgs e)
        {
            if(DescriptionTextBox.BackColor != Color.Red)
            {
                _info = DescriptionTextBox.Text;
            }
            else
            {
                DescriptionTextBox.Text = _info;
            }
        }

        private void CostTextBox_Leave(object obj, EventArgs e)
        {

            if(CostTextBox.BackColor != Color.Red)
            {
                _cost = CostTextBox.Text;
            }
            else
            {
                if (_cost != null)
                {
                    CostTextBox.Text = _cost.ToString();
                }
            }
            
        }

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index != -1)
            {
                items.RemoveAt(index);
                ItemsListBox.Items.RemoveAt(index);
                ClearInputs();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Item selectedItem = (Item)ItemsListBox.SelectedItem;
                IdTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                DescriptionTextBox.Text = selectedItem.Info;
                CostTextBox.Text = selectedItem.Cost.ToString();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string parse = NameTextBox.Text;
                if (parse.Length > 0 && parse.Length < 200)
                {
                    NameTextBox.BackColor = Color.White;
                }
                else
                {
                    NameTextBox.BackColor = Color.Red;
                }
            }
            catch
            {
                NameTextBox.BackColor= Color.Red;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double parse = double.Parse(CostTextBox.Text);
                if (parse > 0 && parse < 100000)
                {
                    CostTextBox.BackColor = Color.White;
                }
                else
                {
                    CostTextBox.BackColor = Color.Red;
                }
            }
            catch
            {
                CostTextBox.BackColor = Color.Red;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string parse = DescriptionTextBox.Text;
                if (parse.Length > 0 && parse.Length < 1000)
                {
                    DescriptionTextBox.BackColor = Color.White;
                }
                else
                {
                    DescriptionTextBox.BackColor = Color.Red;
                }
            }
            catch
            {
                DescriptionTextBox.BackColor = Color.Red;
            }
        }
    }
}
