using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        private DateTime _dateTime;
        private string _time;

        private static string[] _times =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public static string[] Times { get { return _times; } }

        public string Time
        {
            set
            {
                foreach (string time in _times)
                {
                    if (value == time)
                    {
                        _time = time;
                        return;
                    }

                }
                throw new ArgumentException("Неправильное время");
            }
            get { return _time; }
        }


        public PriorityOrder(OrderStatus status, Address address, List<Item> items/*, DateTime datetime, string time */):base(status, address, items)
        {
            //DateTime = datetime;
            //Time = time;
        }

        public PriorityOrder() : base() { }
    }

}
