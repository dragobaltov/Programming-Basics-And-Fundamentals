using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());

            if (category == "VIP")
            {
                if (numberPeople >= 1 && numberPeople <= 4)
                {
                    budget *= 0.25;
                    if (budget >= numberPeople * 499.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 499.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 499.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 5 && numberPeople <= 9)
                {
                    budget *= 0.4;
                    if (budget >= numberPeople * 499.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 499.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 499.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 10 && numberPeople <= 24)
                {
                    budget *= 0.5;
                    if (budget >= numberPeople * 499.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 499.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 499.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 25 && numberPeople <= 49)
                {
                    budget *= 0.6;
                    if (budget >= numberPeople * 499.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 499.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 499.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 50)
                {
                    budget *= 0.75;
                    if (budget >= numberPeople * 499.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 499.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 499.99) - budget:F2} leva.");
                    }
                }
            }
            else if(category == "Normal")
            {
                if (numberPeople >= 1 && numberPeople <= 4)
                {
                    budget *= 0.25;
                    if (budget >= numberPeople * 249.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 249.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 249.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 5 && numberPeople <= 9)
                {
                    budget *= 0.4;
                    if (budget >= numberPeople * 249.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 249.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 249.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 10 && numberPeople <= 24)
                {
                    budget *= 0.5;
                    if (budget >= numberPeople * 249.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 249.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 249.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 25 && numberPeople <= 49)
                {
                    budget *= 0.6;
                    if (budget >= numberPeople * 249.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 249.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 249.99) - budget:F2} leva.");
                    }
                }
                else if (numberPeople >= 50)
                {
                    budget *= 0.75;
                    if (budget >= numberPeople * 249.99)
                    {
                        Console.WriteLine($"Yes! You have {budget - (numberPeople * 249.99):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(numberPeople * 249.99) - budget:F2} leva.");
                    }
                }
            }
        }
    }
}
