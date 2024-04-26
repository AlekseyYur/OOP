using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Item
    {
        //индификатор
        private readonly int _id = IdGenerator.GetId();
        //название товара
        private string _name;
        //описание
        private string _info;
        //стоимость
        private double _cost;
        //категория товара
        private Category _category;


        //св-во поля название товара
        public string Name
        {
            set { _name = ValueValidator.AssertStringOnLength(value, 200, "name"); }
            get { return _name; }
        }
        //св-во поля описание
        public string Info
        {
            set { _info = ValueValidator.AssertStringOnLength(value, 1000, "info"); }
            get { return _info; }
        }
        //св-во поля стоимость
        public double Cost
        {
            set
            {
                if (value > 0 && value <= 100000)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentException("Out of lenght");
                }
            }
            get { return _cost; }
        }
        //индификатор
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Категория товара
        /// </summary>
        public Category Category
        {
            set => _category = value;
            get { return _category; }
        }

        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            Category = Category.Other;
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">индификатор</param>
        /// <param name="info">описание</param>
        /// <param name="cost">стоимость</param>
        /// <param name="category">категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        //Отображение в listbox
        public override string ToString()
        {
            return Name; // Возвращаем значение свойства Name
        }

        public object Clone()
        {
            var item = new Item();
            item.Name = Name;
            item.Info = Info;
            item.Cost = Cost;
            item.Category = Category;

            return item;
        }
    }

    /// <summary>
    /// Категории товара
    /// </summary>
    public enum Category
    {
        Toy,
        Food,
        Electronic,
        Cloth,
        Shoes,
        Sport,
        Medicine,
        Furniture,
        Accessory,
        Game,
        Other
    }
}
