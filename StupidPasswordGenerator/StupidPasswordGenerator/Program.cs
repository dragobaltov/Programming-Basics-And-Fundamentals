using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string ch = Convert.ToChar(l).ToString();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 1; k <= l; k++)
                    {
                        for (int h = 1; h <= l; h++)
                        {
                            for (int u = 2; u <= n; u++)
                            {
                                if (u > i && u > j)
                                {
                                    Console.Write($"{i}{j}{Convert.ToChar(k + 96)}{Convert.ToChar(h + 96)}{u} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
