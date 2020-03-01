using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s = args[0];
            foreach (char i in s)
            {
                int i2 = i;
                byte b = Convert.ToByte(i);
                Console.WriteLine(i2);
                Console.WriteLine(b.ToString("x"));
            }
        }
    }
}
