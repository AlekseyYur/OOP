using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
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

        public List<Item> Items
        {
            get { return  _items; }
            set { _items = value; }
        }

        public Cart()
        {
            Items = new List<Item>();
        }

        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
