using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int firstNumber = 1;
            //int secondNumber = 1;
            //int thirdNumber = 1;
            //int forthNumber = 1;
            //int fifthNumber = 1;
            //int sixthNumber = 1;

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
                                    if ((i * j * k * l * g * h) == n)
                                    {
                                        Console.Write($"{i}{j}{k}{l}{g}{h} ");
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
