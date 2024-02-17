using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс Покупателя
    /// </summary>
    internal class Customer
    {
        private static int count = 0;

        private readonly int _id = count++;
        private string _fullname;
        private string _address;

        ValueValidator Validator = new ValueValidator();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="fullname">ФИО</param>
        /// <param name="address">Адрес</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Свойство Id
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Свойство ФИО
        /// </summary>
        public string Fullname
        {
            set
            {
                _fullname = Validator.AssertStringOnLength(value, 200, Fullname);
            }
            get { return _fullname; }
        }

        /// <summary>
        /// Свойство Адреса
        /// </summary>
        public string Address
        {
            set
            {
                _address = Validator.AssertStringOnLength(value, 500, Address);
            }
            get { return _address; }
        }


        public override string ToString()
        {
            return Fullname; // Возвращаем значение свойства Name
        }
    }
}
