using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void PrintToConsole()
        {
            Console.WriteLine("X: {0}; Y: {1}", X, Y);
        }
    }
}
