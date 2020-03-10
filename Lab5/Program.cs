using System;
using System.Collections.Generic;

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

    public class MyStack<T>
    {
        private List<T> list;

        public void Add(T x)
        {
            if (list == null)
            {
                list = new List<T>{x};
            }
            else
            {
                list.Add(x);
            }
            
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T a = list[list.Count-1];
            list.RemoveAt(list.Count - 1);
            return a;
        }
    }
}
