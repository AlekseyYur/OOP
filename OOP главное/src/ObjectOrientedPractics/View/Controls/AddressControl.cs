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
using ObjectOrientedPractics.Servises;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Цвет <see cref="TextBox"/>, успешно прошедшего валидацию. 
        /// </summary>
        private Color RightInputColor { get; } = Color.White;

        /// <summary>
        /// Цвет <see cref="TextBox"/>, неудачно прошедшего валидацию. 
        /// </summary>
        private Color WrongInputColor { get; } = Color.Red;

        public AddressControl()
        {
            InitializeComponent();
            WrongInputLabel.Text = "";

        }

        /// <summary>
        /// Создание нового экземпляра класса
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Свойство для адреса
        /// </summary>
        public Address Address
        {
            set
            {
                _address = value;
                UpdateTextBoxes();
            }
            get
            { 
                return _address; 
            }
        }

        /// <summary>
        /// Обновляет данные текстовых полей ввода
        /// </summary>
        private void UpdateTextBoxes()
        {

            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;

        }

        //Изменение поля индекс
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PostIndexTextBox.Text.Length == 6 & int.TryParse(PostIndexTextBox.Text, out var temp))
            {
                PostIndexTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                PostIndexTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "Post Index must have 6 symbols.";
            }
        }

        //Изменение поля cтрана
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextBox.Text.Length <= 50)
            {
                CountryTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                CountryTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "Country must have less 50 symbols.";
            }
        }

        //Изменение поля город
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text.Length <= 50)
            {
                CityTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                CityTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "City must have less 50 symbols.";
            }
        }

        //Изменение поля улица
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StreetTextBox.Text.Length <= 100)
            {
                StreetTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                StreetTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "Street must have less 100 symbols.";
            }
        }

        //Изменение поля дом
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingTextBox.Text.Length <= 10)
            {
                BuildingTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                BuildingTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "Building must have less 10 symbols.";
            }
        }

        //Изменение поля квартир
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ApartmentTextBox.Text.Length <= 10)
            {
                ApartmentTextBox.BackColor = RightInputColor;
                WrongInputLabel.Text = "";
            }
            else
            {
                ApartmentTextBox.BackColor = WrongInputColor;
                WrongInputLabel.Text = "Apartment must have less 10 symbols.";
            }
        }

        //Ввод данных
        private void PostIndexTextBox_Leave(object sender, EventArgs e)
        {

            if (PostIndexTextBox.BackColor == RightInputColor)
            {
                Address.Index = int.Parse(PostIndexTextBox.Text);
            }
        }

        //Ввод данных
        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            if (CountryTextBox.BackColor == RightInputColor)
            {
                Address.Country = CountryTextBox.Text;
            }
        }

        //Ввод данных
        private void CityTextBox_Leave(object sender, EventArgs e)
        {

            if (CityTextBox.BackColor == RightInputColor)
            {
                Address.City = CityTextBox.Text;
            }
        }

        //Ввод данных
        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            if (StreetTextBox.BackColor == RightInputColor)
            {
                Address.Street = StreetTextBox.Text;
            }
        }

        //Ввод данных
        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            if (BuildingTextBox.BackColor == RightInputColor)
            {
                Address.Building = BuildingTextBox.Text;
            }
        }

        //Ввод данных
        private void ApartmentTextBox_Leave(object sender, EventArgs e)
        {
            if (ApartmentTextBox.BackColor == RightInputColor)
            {
                Address.Apartment = ApartmentTextBox.Text;
            }
        }
    }
}
