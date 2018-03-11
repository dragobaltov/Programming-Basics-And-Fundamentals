using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    double prise = 2 * 56 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <=1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
                else if (size == "big")
                {
                    double prise = 5 * 28.7 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    double prise = 2 * 36.66 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
                else if (size == "big")
                {
                    double prise = 5 * 19.6 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    double prise = 2 * 42.1 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
                else if (size == "big")
                {
                    double prise = 5 * 24.8 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    double prise = 2 * 20 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
                else if (size == "big")
                {
                    double prise = 5 * 15.2 * quantity;
                    if (prise < 400)
                    {
                        Console.WriteLine($"{prise:F2} lv.");
                    }
                    else if (prise >= 400 && prise <= 1000)
                    {
                        Console.WriteLine($"{prise * 0.85:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{prise * 0.5:F2} lv.");
                    }
                }
            }
        }
    }
}
