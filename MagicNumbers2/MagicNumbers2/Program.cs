using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            for (int g = 1; g <= 9; g++)
                            {
                                for (int h = 1; h <= 9; h++)
                                {
                                    if (i * j * k * l * g * h == magicNumber)
                                    {
                                        Console.Write($"{Convert.ToString(i)}{Convert.ToString(j)}{Convert.ToString(k)}{Convert.ToString(l)}{Convert.ToString(g)}{Convert.ToString(h)} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
