﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            String s;
            s = "Hello!";

            Boolean b = i == 5;
            char c = '\u0308';
            string s2 = s;

            Boolean b1 = new bool();

            char[] c2 = new char[1];
            c2[0] = c;
            string s3 = new String(c2);
            // Console.WriteLine(s3);

            double i2 = i;
            Single i3 = (float)i2;
            long i4 = i;
            char c3 = (char)i;
            i += 10000000;
            byte by1 = (byte)i;
            char c4 = (char)i;
            Console.WriteLine((int)c4);


            object o1 = i;

            double i5 = i + i2 + i3;
            Console.WriteLine(i5);
        }
    }
}
