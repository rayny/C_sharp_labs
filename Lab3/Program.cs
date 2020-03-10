using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Day[, ] weeks = new Day[10, 7];
            for (int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 7; j++)
                {

                }
            }
        }
    }

    public class Day
    {
        enum ISworkingDay { Working, Weekend}
        ISworkingDay workingDay { get; set; }
        List<Purchase> purchases { get; set; }
    }

    public class Purchase
    {
        int amount { get; set; }
        enum IScash { Cash, Card}
        IScash cash { get; set; }
    }
}
