using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");
            decimal length = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            decimal width = decimal.Parse(Console.ReadLine());

            decimal area = length * width;
            decimal perimeter = (2 * length) + (2 * width);

            Console.WriteLine("Area: {0}",area);
            Console.WriteLine("Perimeter: {0}", perimeter);

            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine();

            if (input == "Y" || input == "y")
            {
                Console.WriteLine("Enter Height");
                decimal height = decimal.Parse(Console.ReadLine());

                decimal volume = length * width * height;

                Console.WriteLine("Volume: {0}", volume);

            }
            else if (input == "N" || input == "n")
                    {
                Console.WriteLine("Well have a nice day.");
            }



        }
    }
}
