using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель
    /// </summary>
    public class Customer
    {
        //индификатор
        private readonly int _id = IdGenerator.GetId();
        //имя
        private string _fullname;
        //адрес
        private Address _address;
        //корзина
        private Cart _cart;
        //заказы
        private List<Order> _orders;
        //приоритет
        private bool _isPriority;
        //cписок скидок
        private List<IDiscount> _discounts;


        //заказы
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        //корзина
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }
        
        //имя
        public string FullName
        {
            set { _fullname = ValueValidator.AssertStringOnLength(value, 200, "fullname"); }
            get { return _fullname; }
        }
        //адрес
        public Address Address
        {
            set { _address = value; }
            get { return _address; }
        }
        //индификатор
        public int Id
        {
            get { return _id; }
        }

        //приоритетность
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// cписок скидок
        /// </summary>
        public List<IDiscount> Discounts
        {
            set { _discounts = value; }
            get { return _discounts; }
        }


        /// <summary>
        /// конструктор поумолчанию
        /// </summary>
        public Customer()
        {
            FullName = "OlegBuryat2005";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="address"></param>
        /// <param name="cart"></param>
        public Customer(string fullname, Address address, bool isPriority/*, Cart cart, List<Order> orders*/) 
        {
            FullName = fullname;   
            Address = new Address(address.Index, address.Country, address.City, address.Street, address.Building, address.Apartment);
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = isPriority;
            Discounts = new List<IDiscount>
            {
                new PointsDiscounts()
            };
        }
        //отображение в customerlistbox
        public override string ToString()
        {
            return FullName; // Возвращаем значение свойства Fullname
        }
    }
}
