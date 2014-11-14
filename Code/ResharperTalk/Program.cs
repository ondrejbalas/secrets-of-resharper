using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ResharperTalk.Classes;

namespace ResharperTalk
{
    class Program
    {
        private const double _tax = 1.06;

        static void Main(string[] args)
        {
            var myGuid = "{53B5C2B8-6297-4733-9E0B-5B0978848A2B}";   

            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static double Multiply(double v2, double v1)
        {
            return v1*v2;
        }

        private static List<Func<string>> DoStuff()
        {
            var listOfNumbers = Enumerable.Range(1, 100);
            var list = new List<Func<string>>();
            foreach (var number in listOfNumbers)
            {
                int number1 = number;
                list.Add(() => "The number is " + number1);
            }
            return list;
        }
    }
}
