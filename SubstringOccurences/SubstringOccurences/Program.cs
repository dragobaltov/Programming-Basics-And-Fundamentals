using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string substring = Console.ReadLine().ToLower();
            int counter = 0;

            for (int i = 0; i <= text.Length - substring.Length; i++)
            {
                if (text.ToLower().Substring(i, substring.Length) == substring)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
