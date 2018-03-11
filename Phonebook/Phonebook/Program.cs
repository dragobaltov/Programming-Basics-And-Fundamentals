using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string newNames = String.Empty;

            while (newNames != "done")
            {
                newNames = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (newNames == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
