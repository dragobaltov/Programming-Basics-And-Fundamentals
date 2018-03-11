using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            if (season == "Spring" || season == "Summer")
            {
                if (holidayOrNot == "N")
                {
                    double priceHrizantemi = hrizantemi * 2;
                    double priceRoses = roses * 4.1;
                    double priceLaleta = laleta * 2.5;
                    double priceFlowers = priceHrizantemi + priceLaleta + priceRoses;
                    if (laleta > 7 && season == "Spring")
                    {
                        priceFlowers *= 0.95;
                    }
                    if (hrizantemi + laleta + roses > 20)
                    {
                        priceFlowers *= 0.8; 
                    }
                    Console.WriteLine($"{priceFlowers + 2:F2}");
                }
                else if (holidayOrNot == "Y")
                {
                    double priceHrizantemi = hrizantemi * 2 * 1.15;
                    double priceRoses = roses * 4.1 * 1.15;
                    double priceLaleta = laleta * 2.5 * 1.15;
                    double priceFlowers = priceHrizantemi + priceLaleta + priceRoses;
                    if (laleta > 7 && season == "Spring")
                    {
                        priceFlowers *= 0.95;
                    }
                    if (hrizantemi + laleta + roses > 20)
                    {
                        priceFlowers *= 0.8;
                    }
                    Console.WriteLine($"{priceFlowers + 2:F2}");
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                if (holidayOrNot == "N")
                {
                    double priceHrizantemi = hrizantemi * 3.75;
                    double priceRoses = roses * 4.5;
                    double priceLaleta = laleta * 4.15;
                    double priceFlowers = priceHrizantemi + priceLaleta + priceRoses;
                    if (roses >= 10 && season == "Winter")
                    {
                        priceFlowers *= 0.9;
                    }
                    if (hrizantemi + laleta + roses > 20)
                    {
                        priceFlowers *= 0.8;
                    }
                    Console.WriteLine($"{priceFlowers + 2:F2}");
                }
                else if (holidayOrNot == "Y")
                {
                    double priceHrizantemi = hrizantemi * 3.75 * 1.15;
                    double priceRoses = roses * 4.5 * 1.15;
                    double priceLaleta = laleta * 4.15 * 1.15;
                    double priceFlowers = priceHrizantemi + priceLaleta + priceRoses;
                    if (roses >= 10 && season == "Winter")
                    {
                        priceFlowers *= 0.9;
                    }
                    if (hrizantemi + laleta + roses > 20)
                    {
                        priceFlowers *= 0.8;
                    }
                    Console.WriteLine($"{priceFlowers + 2:F2}");
                }
            }
        }
    }
}
