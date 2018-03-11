using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your password:");
            string password = Console.ReadLine();

            if (!(name == "Pesho" || password == "123"))
            {
                Console.WriteLine("You are not Pesho");
            }
            else if (!(name == "Maria" || password == "abv"))
            {
                Console.WriteLine("You are not Maria");
            }
            else
            {
                Console.WriteLine("Is logged");
            }
        }
    }
}
