using System;

namespace Lib_6
{
    public class Work1
    {
        /// <summary>
        /// Генерировать случайные числа от -5 до 4. для чисел < 0 высчитать вторую степень, числа > 0 возвести в квадратный корень.
        /// </summary>
        /// <param name="count">Количество случайных чисел</param>
        /// <param name="values">Сгенерированные числа</param>
        /// <param name="results">Результаты вычислений</param>
        public static void Function1(ref string values, ref string results)
        {
            Random rnd = new Random();
            double value, lastValue = 7;

            while (true)
            {
                value = rnd.Next(-5, 5);
                values = values + value + "; ";

                if (value > 0) value = Math.Round(Math.Sqrt(value), 2);
                else value = Math.Pow(value, 2);

                results = results + value + "; ";

                if (value == lastValue) break;
                lastValue = value;
            }

        }
    }
}
