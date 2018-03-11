using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Words(n);
        }

        static void Words(int n)
        {
            string[] hundreds = { "one-hundred", "two-hundred", "three-hundred", "four-hundred",
                                  "five-hundred", "six-hundred", "seven-hundred", "eight-hundred", "nine-hundred"};
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                               "eighteen", "nineteen" };
            string[] oneToNine = { "one", "two", "three", "four","five", "six", "seven", "eight", "nine" };
            string[] ty = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                else if ((number >= 100 && number <= 999) || (number <= -100 && number >= -999))
                {
                    if (number < 0)
                    {
                        Console.Write("minus ");
                    }

                    if (number / 100 == 1 || number / 100 == -1)
                    {
                        Console.Write($"{hundreds[0]} ");
                    }
                    else if (number / 100 == 2 || number / 100 == -2)
                    {
                        Console.Write($"{hundreds[1]} ");
                    }
                    else if (number / 100 == 3 || number / 100 == -3)
                    {
                        Console.Write($"{hundreds[2]} ");
                    }
                    else if (number / 100 == 4 || number / 100 == -4)
                    {
                        Console.Write($"{hundreds[3]} ");
                    }
                    else if (number / 100 == 5 || number / 100 == -5)
                    {
                        Console.Write($"{hundreds[4]} ");
                    }
                    else if (number / 100 == 6 || number / 100 == -6)
                    {
                        Console.Write($"{hundreds[5]} ");
                    }
                    else if (number / 100 == 7 || number / 100 == -7)
                    {
                        Console.Write($"{hundreds[6]} ");
                    }
                    else if (number / 100 == 8 || number / 100 == -8)
                    {
                        Console.Write($"{hundreds[7]} ");
                    }
                    else if (number / 100 == 9 || number / 100 == -9)
                    {
                        Console.Write($"{hundreds[8]} ");
                    }

                    if (((number / 10) % 10) == 0)
                    {
                        if (number % 10 == 1 || number % 10 == -1)
                        {
                            Console.Write($"and {oneToNine[0]}");
                        }
                        else if (number % 10 == 2 || number % 10 == -2)
                        {
                            Console.Write($"and {oneToNine[1]}");
                        }
                        else if (number % 10 == 3 || number % 10 == -3)
                        {
                            Console.Write($"and {oneToNine[2]}");
                        }
                        else if (number % 10 == 4 || number % 10 == -4)
                        {
                            Console.Write($"and {oneToNine[3]}");
                        }
                        else if (number % 10 == 5 || number % 10 == -5)
                        {
                            Console.Write($"and {oneToNine[4]}");
                        }
                        else if (number % 10 == 6 || number % 10 == -6)
                        {
                            Console.Write($"and {oneToNine[5]}");
                        }
                        else if (number % 10 == 7 || number % 10 == -7)
                        {
                            Console.Write($"and {oneToNine[6]}");
                        }
                        else if (number % 10 == 8 || number % 10 == -8)
                        {
                            Console.Write($"and {oneToNine[7]}");
                        }
                        else if (number % 10 == 9 || number % 10 == -9)
                        {
                            Console.Write($"and {oneToNine[8]}");
                        }
                    }
                    else if (((number / 10) % 10) == 1 || ((number / 10) % 10) == -1)
                    {
                        if (number % 10 == 0)
                        {
                            Console.Write($"and {teens[0]}");
                        }
                        else if (number % 10 == 1 || number % 10 == -1)
                        {
                            Console.Write($"and {teens[1]}");
                        }
                        else if (number % 10 == 2 || number % 10 == -2)
                        {
                            Console.Write($"and {teens[2]}");
                        }
                        else if (number % 10 == 3 || number % 10 == -3)
                        {
                            Console.Write($"and {teens[3]}");
                        }
                        else if (number % 10 == 4 || number % 10 == -4)
                        {
                            Console.Write($"and {teens[4]}");
                        }
                        else if (number % 10 == 5 || number % 10 == -5)
                        {
                            Console.Write($"and {teens[5]}");
                        }
                        else if (number % 10 == 6 || number % 10 == -6)
                        {
                            Console.Write($"and {teens[6]}");
                        }
                        else if (number % 10 == 7 || number % 10 == -7)
                        {
                            Console.Write($"and {teens[7]}");
                        }
                        else if (number % 10 == 8 || number % 10 == -8)
                        {
                            Console.Write($"and {teens[8]}");
                        }
                        else if (number % 10 == 9 || number % 10 == -9)
                        {
                            Console.Write($"and {teens[9]}");
                        }
                    }
                    else
                    {
                        if (((number / 10) % 10) == 2 || ((number / 10) % 10) == -2)
                        {
                            Console.Write($"and {ty[0]}");
                        }
                        else if (((number / 10) % 10) == 3 || ((number / 10) % 10) == -3)
                        {
                            Console.Write($"and {ty[1]}");
                        }
                        else if (((number / 10) % 10) == 4 || ((number / 10) % 10) == -4)
                        {
                            Console.Write($"and {ty[2]}");
                        }
                        else if (((number / 10) % 10) == 5 || ((number / 10) % 10) == -5)
                        {
                            Console.Write($"and {ty[3]}");
                        }
                        else if (((number / 10) % 10) == 6 || ((number / 10) % 10) == -6)
                        {
                            Console.Write($"and {ty[4]}");
                        }
                        else if (((number / 10) % 10) == 7 || ((number / 10) % 10) == -7)
                        {
                            Console.Write($"and {ty[5]}");
                        }
                        else if (((number / 10) % 10) == 8 || ((number / 10) % 10) == -8)
                        {
                            Console.Write($"and {ty[6]}");
                        }
                        else if (((number / 10) % 10) == 9 || ((number / 10) % 10) == -9)
                        {
                            Console.Write($"and {ty[7]}");
                        }

                        if (number % 10 == 1 || number % 10 == -1)
                        {
                            Console.Write($" {oneToNine[0]}");
                        }
                        else if (number % 10 == 2 || number % 10 == -2)
                        {
                            Console.Write($" {oneToNine[1]}");
                        }
                        else if (number % 10 == 3 || number % 10 == -3)
                        {
                            Console.Write($" {oneToNine[2]}");
                        }
                        else if (number % 10 == 4 || number % 10 == -4)
                        {
                            Console.Write($" {oneToNine[3]}");
                        }
                        else if (number % 10 == 5 || number % 10 == -5)
                        {
                            Console.Write($" {oneToNine[4]}");
                        }
                        else if (number % 10 == 6 || number % 10 == -6)
                        {
                            Console.Write($" {oneToNine[5]}");
                        }
                        else if (number % 10 == 7 || number % 10 == -7)
                        {
                            Console.Write($" {oneToNine[6]}");
                        }
                        else if (number % 10 == 8 || number % 10 == -8)
                        {
                            Console.Write($" {oneToNine[7]}");
                        }
                        else if (number % 10 == 9 || number % 10 == -9)
                        {
                            Console.Write($" {oneToNine[8]}");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
