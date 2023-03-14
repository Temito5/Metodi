using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovdiganeNaStepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powerOf = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPowers(number, powerOf));
        }

        private static double RaiseToPowers(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
