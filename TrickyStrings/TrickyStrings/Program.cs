using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                if (i != n)
                {
                    Console.Write(text + delimeter);
                }
                else
                {
                    Console.Write(text);
                }
            }
        }
    }
}
