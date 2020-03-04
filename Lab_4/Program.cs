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
            s.AppendFormat(formatString, "Ваня", String.Format("{0}Звездочка{0}", '"'), "01.01.1970", "150 €");
            s.AppendFormat(formatString, "Петя", String.Format("{0}ООО {0}Вектор{0}{0}", '"'), "01.01.1970", "300 ₽");
            s.AppendFormat(formatString, "Маша", String.Format("{0}Звездочка{0}", '"'), "01.01.1970", "150 €");
            s.AppendFormat(formatString, "Даша", String.Format("{0}ООО {0}Вектор{0}{0}", '"'), "01.01.1970", "300 ₽");
            Console.WriteLine(s.ToString());
        }
    }
}
