using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 97; k < 97 + l; k++)
                    {
                        for (int g = 97; g < 97 + l; g++)
                        {
                            for (int h = 1; h <= n; h++)
                            {
                                if (h > i && h > j)
                                {
                                    Console.Write($"{i}{j}{Convert.ToChar(k)}{Convert.ToChar(g)}{h} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
