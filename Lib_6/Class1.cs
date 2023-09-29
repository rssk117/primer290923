using System;

namespace Lib_6
{
    public class Work1
    {
        /// <summary>
        /// ������������ ��������� ����� �� -5 �� 4. ��� ����� < 0 ��������� ������ �������, ����� > 0 �������� � ���������� ������.
        /// </summary>
        /// <param name="count">���������� ��������� �����</param>
        /// <param name="values">��������������� �����</param>
        /// <param name="results">���������� ����������</param>
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
