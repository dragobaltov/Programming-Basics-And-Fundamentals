using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityStadium = int.Parse(Console.ReadLine());
            int numberFans = int.Parse(Console.ReadLine());
            int sectionA = 0;
            int sectionB = 0;
            int sectionV = 0;
            int sectionG = 0;

            for (int i = 0; i < numberFans; i++)
            {
                string section = Console.ReadLine();
                if (section == "A")
                {
                    sectionA += 1;
                }
                else if (section == "B")
                {
                    sectionB += 1;
                }
                else if (section == "V")
                {
                    sectionV += 1;
                }
                else if (section == "G")
                {
                    sectionG += 1;
                }
            }
            Console.WriteLine($"{sectionA * 1.0 / numberFans * 100:F2}%");
            Console.WriteLine($"{sectionB * 1.0 / numberFans * 100:F2}%");
            Console.WriteLine($"{sectionV * 1.0 / numberFans * 100:F2}%");
            Console.WriteLine($"{sectionG * 1.0 / numberFans * 100:F2}%");
            Console.WriteLine($"{numberFans * 1.0 / capacityStadium * 100:F2}%");
        }
    }
}
