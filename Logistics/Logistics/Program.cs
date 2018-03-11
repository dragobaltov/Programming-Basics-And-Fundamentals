using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityLuggage = int.Parse(Console.ReadLine());
            double tonsWithBus = 0.0;
            double tonsWithTruck = 0.0;
            double tonsWithTrain = 0.0;
            for (int i = 1; i <= quantityLuggage; i++)
            {
                int tonsOfLuggage = int.Parse(Console.ReadLine());
                if (tonsOfLuggage <= 3)
                {
                    tonsWithBus += tonsOfLuggage;
                }
                else if (tonsOfLuggage >= 4 && tonsOfLuggage <= 11)
                {
                    tonsWithTruck += tonsOfLuggage;
                }
                else if (tonsOfLuggage >= 12)
                {
                    tonsWithTrain += tonsOfLuggage;
                }
            }
            double allTons = tonsWithBus + tonsWithTrain + tonsWithTruck;
            double moneyBus = tonsWithBus * 200;
            double moneyTruck = tonsWithTruck * 175;
            double moneyTrain = tonsWithTrain * 120;
            double allMoney = moneyBus + moneyTruck + moneyTrain;
            Console.WriteLine($"{allMoney / allTons:F2}");
            Console.WriteLine($"{tonsWithBus / allTons * 100:F2}%");
            Console.WriteLine($"{tonsWithTruck / allTons * 100:F2}%");
            Console.WriteLine($"{tonsWithTrain / allTons * 100:F2}%");
        }
    }
}
