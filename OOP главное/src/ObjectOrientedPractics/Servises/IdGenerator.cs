using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для хранения и возврата уникального индификатора
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// Счётчик уникальных индификаторов
        /// </summary>
        private static int Сounter { get; set; } = 0;

        /// <summary>
        /// Возвращает уникальный индификатор и создаёт новый
        /// </summary>
        /// <returns>Индификатор</returns>
        public static int GetId()
        {
            return Сounter++;
        }
    }
}
