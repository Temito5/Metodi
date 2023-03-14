﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzchertavaneNaZapulnenKvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintHeaderRow(num);
            PrintMiddleRow(num);
            PrintMiddleRow(num); 
            PrintFooterRow(num);
        }

        private static void PrintFooterRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        private static void PrintMiddleRow(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
