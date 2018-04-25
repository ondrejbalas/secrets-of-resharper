using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ResharperTalk
{
    class Program
    {
        private const double Tax = 1.06;

        static void Main(string[] args)
        {
            {
                var quantity = 10;
                var price = 9.95;

                var subtotal = quantity * price;
                var totalPrice = subtotal * Tax;
            }

            Console.WriteLine("31ED3F15-084A-426A-9901-B5372FAED624");

            Console.WriteLine("\nPress enter to exit");
            Console.ReadLine();
        }

        private static void NewMethod(string something2, string something)
        {
            var listOfNumbers = Enumerable.Range(1, 100);
            var sumOfNumbers = listOfNumbers.Sum();

            Console.WriteLine("The sum is: {0}", sumOfNumbers);
        }
    }
}
