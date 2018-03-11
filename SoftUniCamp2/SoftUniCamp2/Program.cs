using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double counterCar = 0;
            double counterMicrobus = 0;
            double counterSmallBus = 0;
            double counterBigBus = 0;
            double counterTrain = 0;


            for (int i = 1; i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    counterCar += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    counterMicrobus += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    counterSmallBus += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    counterBigBus += people;
                }
                else
                {
                    counterTrain += people;
                }
            }

            double allPeople = counterCar + counterMicrobus + counterSmallBus + counterBigBus + counterTrain;

            Console.WriteLine($"{counterCar * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{counterMicrobus * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{counterSmallBus * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{counterBigBus * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{counterTrain * 1.0 / allPeople * 100:F2}%");
        }
    }
}
