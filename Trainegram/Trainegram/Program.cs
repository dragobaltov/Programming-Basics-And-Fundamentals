using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trains = new List<string>();
            Regex pattern = new Regex(@"^(\<\[[^\dA-Za-z]*\]\.)(\.\[[\da-zA-Z]*\]\.)*$");

            while (!input.Equals("Traincode!"))
            {
                if (pattern.IsMatch(input))
                {
                    trains.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var item in trains)
            {
                Console.WriteLine(item);
            }
        }
    }
}
