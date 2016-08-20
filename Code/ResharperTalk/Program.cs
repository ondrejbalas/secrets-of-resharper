using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ResharperTalk.Classes;

namespace ResharperTalk
{
    class Program
    {
        private const double Tax = 1.06;

        static void Main(string[] args)
        {
            var myList = new LoggingList<string>(new List<string>());
            myList.Add("hello Music City Code");

            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static double GetValue(int quantity, double price)
        {
            var subtotal = quantity*price;
            var totalPrice = subtotal*Tax;
            return totalPrice;
        }

        private static void DoStuff()
        {
            var myPattern = new Regex("Hello Music \\w+ Code!");
            int number = 1 + 2*3*(4 + 5) + 6;

            var listOfNumbers = Enumerable.Range(1, 100);
            var sumOfNumbers = listOfNumbers.Sum();

            Console.WriteLine("The sum is: {0}", sumOfNumbers);
        }
    }
}
