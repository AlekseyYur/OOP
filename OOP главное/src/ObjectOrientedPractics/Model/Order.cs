using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private readonly int _id = IdGenerator.GetId();
        private readonly DateTime _date = DateTime.Now;
        public OrderStatus _status;
        private Address _address;
        private List<Item> _items;
        private double _amount;

        public double Amount
        {
            get
            {
                if (_items == null) 
                {
                    _amount = 0.0;
                    return _amount;
                }
                else
                {
                    for (int i = 0; i < _items.Count; i++)
                    {
                        _amount += _items[i].Cost;
                    }
                    return _amount;
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экзепляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Status = OrderStatus.New;
            Address = new Address();
            Items = new List<Item>();
        }

        /// <summary>
        /// Создает экзепляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        public Order(OrderStatus status, Address address, List<Item> items)
        {
            Status = status;
            Address = address;
            Items = items;
        }
    }

    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
