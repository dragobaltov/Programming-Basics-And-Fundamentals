using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string[] tokens = input.Split(new string[] { delimeter }, StringSplitOptions.None);

            Console.Write("[");
            Console.Write(string.Join(", ",tokens));
            Console.WriteLine("]");
        }
    }
}
