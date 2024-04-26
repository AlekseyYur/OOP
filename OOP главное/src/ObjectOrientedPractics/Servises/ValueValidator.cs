using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Servises
{
    /// <summary>
    /// Валидация строковой переменной
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Валидирует строковую переменную
        /// </summary>
        /// <param name="value">Переменная</param>
        /// <param name="maxLength">Максимальная длина переменной</param>
        /// <param name="propertyName">Название переменной</param>
        /// <returns>Возвращает валидированную переменную</returns>
        /// <exception cref="ArgumentException">Вызывает исключение, если переменная не прошла валидацию</exception>
        public static string AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > 0 && value.Length <= maxLength) 
            { 
                return value;
            }
            else
            {
                throw new ArgumentException($"Out of lenght; {propertyName}  must be <  {maxLength}");
            }
        }
    }
}
