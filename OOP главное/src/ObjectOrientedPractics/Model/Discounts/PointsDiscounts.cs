using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscounts: IDiscount
    {
        private int _points;

        public int Points
        {
            get { return _points; }
            private set { _points = value; }
        }

        /// <summary>
        /// Вычисляет размер скидки доступной для списка товаров.
        /// Скидка товаров не божет быть больше 30% от общей суммы товаров.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                cost += item.Cost;
            }

            //Расчёт максимальной скидки
            double maxDiscont = Math.Truncate(cost * 0.3);

            if ((int)maxDiscont < Points) { return maxDiscont; }
            else { return Points; }
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
            //Снятие баллов
            Points -= (int)discount;

            return discount;
        }

        /// <summary>
        /// Добавляет баллы на основе списка товаров
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            //Стоимость товаров
            double cost = 0;
            foreach (var item in items)
            {
                cost += item.Cost;
            }

            //Количество добавляемых баллов
            double newPoints = cost * 0.1;
            //Округление
            if ((newPoints % 1) > 0)
            {
                newPoints = Math.Truncate(newPoints) + 1;
            }

            Points += (int)newPoints;
        }

        /// <summary>
        /// Возвращает информацию о баллах
        /// </summary>
        public string Info
        {
            get
            {
                string info = $"Накопительная – {Points}  баллов";
                return (info);
            }
        }

        public PointsDiscounts()
        {
            Points = 0;
        }


    }
}
