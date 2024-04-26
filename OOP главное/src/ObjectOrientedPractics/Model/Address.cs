using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        //почтовый индекс, целое шестизначное число
        private int _index;
        //страна/регион, строка, не более 50 символов
        private string _country;
        //город (населенный пункт), строка, не более 50 символов
        private string _city;
        //улица, строка, не более 100 символов
        private string _street;
        //номер дома, строка, не более 10 символов
        private string _building;
        //номер квартиры/помещения, не более 10 символов
        private string _apartment;

        //почтовый индекс, целое шестизначное число
        public int Index
        {
            set
            {
                if (value > 99999 & value <= 999999)
                {
                    _index = value;
                }
                else
                {
                    throw new Exception("Index must have 6 symbols");
                }
            }

            get { return _index; }
        }

        //страна/регион, строка, не более 50 символов.
        public string Country
        {
            set { _country = ValueValidator.AssertStringOnLength(value, 50, "country"); }
            get { return _country; }
        }

        //город (населенный пункт), строка, не более 50 символов
        public string City
        {
            set { _city = ValueValidator.AssertStringOnLength(value, 50, "city"); }
            get { return _city; }
        }

        //улица, строка, не более 100 символов
        public string Street
        {
            set { _street = ValueValidator.AssertStringOnLength(value, 100, "street"); }
            get { return _street; }
        }

        //номер дома, строка, не более 10 символов
        public string Building
        {
            set { _building = ValueValidator.AssertStringOnLength(value, 10, "building"); }
            get { return _building; }
        }

        //номер квартиры/помещения, не более 10 символов
        public string Apartment
        {
            set { _apartment = ValueValidator.AssertStringOnLength(value, 10, "apartment"); }
            get { return _apartment; }
        }

        public Address ()
        {
            Index = 666666;
            Country = "-";
            City = "-";
            Street = "-";
            Building = "-";
            Apartment = "-";
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="index">Почтовый индекс</param>
        /// <param name="country">Страна проживания</param>
        /// <param name="city">Город проживания</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Номер дома</param>
        /// <param name="apartment">Номер квартиры</param>
        public Address (int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
