using System;
using System.Text;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            string formatString = "{0,-20}|{1,-20}|{2,-20}|{3,20}\n";
            s.AppendFormat(formatString, "Сотрудник", "Название Кампании", "Дата устройства", "Сумма продаж");
            s.AppendFormat(formatString, "Ваня", "\"Звездочка\"", "01.01.1970", "150 €");
            s.AppendFormat(formatString, "Петя", "\"ООО \"Вектор\"", "01.01.1970", "300 ₽");
            s.AppendFormat(formatString, "Маша", "\"Звездочка\"", "01.01.1970", "150 €");
            s.AppendFormat(formatString, "Даша", "\"ООО \"Вектор\"", "01.01.1970", "300 ₽");
            Console.WriteLine(s.ToString());
        }
    }
}
