using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscounts : IDiscount
    {
        //Категория скидки
        private Category _category;
        //Величина скидки
        private int _discont;
        //Сумма покупок
        private double _amount;

        /// <summary>
        /// Категория скидки
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Величина скидки
        /// </summary>
        public int Discont
        {
            get => _discont;
            set
            {
                _discont = value;
                if (_discont > 10)
                {
                    _discont = 10;
                }
            }
        }

        /// <summary>
        /// Сумма покупок
        /// </summary>
        public double Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                Discont = (int)Math.Truncate(_amount * 0.001);
            }
        }


        /// <summary>
        /// Принимает на вход список товаров и возвращает размер скидки
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    cost += item.Cost;
                }

            }

            //Расчёт скидки
            double currentDiscont = cost * Discont / 100;

            return currentDiscont;
        }

        /// <summary>
        /// Применяет скидку к списку товаров 
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Apply(List<Item> items)
        {
            //Расчёт скидки
            double discount = Calculate(items);

            return discount;
        }

        /// <summary>
        /// Добавляет сумму на основе полученного списка товаров
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    cost += item.Cost;
                }

            }

            Amount += cost;
        }


        /// <summary>
        /// Возвращает информацию о скидке
        /// </summary>
        public string Info
        {
            get
            {
                string info = $"Процентная «{Category.ToString()}»{ Discont}%";
                return (info);
            }
        }

        public PercentDiscounts(Category category)
        {
            Category = category;
            Amount = 0;
        }
    }
}
