using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            double tonsMicrobus = 0.0;
            double tonsTruck = 0.0;
            double tonsTrain = 0.0;

            for (int i = 0; i < quantity; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    tonsMicrobus += tons;
                    price += 200 * tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    tonsTruck += tons;
                    price += 175 * tons;
                }
                else
                {
                    tonsTrain += tons;
                    price += 120 * tons;
                }
            }

            double allTons = tonsMicrobus + tonsTruck + tonsTrain;

            Console.WriteLine($"{price / allTons:F2}");
            Console.WriteLine($"{tonsMicrobus / allTons * 100:F2}%");
            Console.WriteLine($"{tonsTruck / allTons * 100:F2}%");
            Console.WriteLine($"{tonsTrain / allTons * 100:F2}%");
        }
    }
}
