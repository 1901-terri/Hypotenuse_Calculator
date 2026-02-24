using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypotenuse_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hypotenuse Calculator by Terri :)");

            Console.WriteLine("\nEnter Side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("The Hypotenuse is " + c);

            Console.ReadKey();
        }
    }
}
