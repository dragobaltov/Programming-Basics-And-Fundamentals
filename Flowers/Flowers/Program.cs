using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityHrizantemi = int.Parse(Console.ReadLine());
            int quantityRoses = int.Parse(Console.ReadLine());
            int quantityLaleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();
            // + 2 lv for preparing
            //        Сезон   Хризантеми       Рози             Лалета
            //  Пролет/Лято   2.00 лв./ бр.    4.10 лв./ бр.    2.50 лв./ бр.
            //    Есен/Зима   3.75 лв./ бр.    4.50 лв./ бр.    4.15 лв./ бр.

            if (holidayOrNot == "Y")
            {
                if (season == "Spring")
                {
                    double priceFlowers = (quantityHrizantemi * 2 + quantityRoses * 4.1 + quantityLaleta * 2.5) * 1.15;
                    if (quantityLaleta > 7)
                    {
                        priceFlowers *= 0.95;
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                    else
                    {
                        if (quantityLaleta + quantityRoses + quantityHrizantemi >= 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                }
                else if (season == "Summer")
                {
                    double priceFlowers = (quantityHrizantemi * 2 + quantityRoses * 4.1 + quantityLaleta * 2.5) * 1.15;
                    if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                    {
                        priceFlowers *= 0.8;
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                }
                else if (season == "Winter")
                {
                    double priceFlowers = (quantityHrizantemi * 3.75 + quantityRoses * 4.5 + quantityLaleta * 4.15) * 1.15;
                    if (quantityRoses >= 10)
                    {
                        priceFlowers *= 0.9;
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                    else
                    {
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                }
                else if (season == "Autumn")
                {
                    double priceFlowers = (quantityHrizantemi * 3.75 + quantityRoses * 4.5 + quantityLaleta * 4.15) * 1.15;
                    if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                    {
                        priceFlowers *= 0.8;
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                }
            }
            else if (holidayOrNot == "N")
            {
                if (season == "Spring")
                {
                    double priceFlowers = (quantityHrizantemi * 2 + quantityRoses * 4.1 + quantityLaleta * 2.5);
                    if (quantityLaleta > 7)
                    {
                        priceFlowers *= 0.95;
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                    else
                    {
                        if (quantityLaleta + quantityRoses + quantityHrizantemi >= 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                }
                else if (season == "Summer")
                {
                    double priceFlowers = (quantityHrizantemi * 2 + quantityRoses * 4.1 + quantityLaleta * 2.5);
                    if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                    {
                        priceFlowers *= 0.8;
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                }
                else if (season == "Winter")
                {
                    double priceFlowers = (quantityHrizantemi * 3.75 + quantityRoses * 4.5 + quantityLaleta * 4.15);
                    if (quantityRoses >= 10)
                    {
                        priceFlowers *= 0.9;
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                    else
                    {
                        if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                        {
                            priceFlowers *= 0.8;
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{priceFlowers + 2:F2}");
                        }
                    }
                }
                else if (season == "Autumn")
                {
                    double priceFlowers = (quantityHrizantemi * 3.75 + quantityRoses * 4.5 + quantityLaleta * 4.15);
                    if (quantityLaleta + quantityRoses + quantityHrizantemi > 20)
                    {
                        priceFlowers *= 0.8;
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{priceFlowers + 2:F2}");
                    }
                }
            }
        }
    }
}
