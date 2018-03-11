using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] array = text.ToArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}
