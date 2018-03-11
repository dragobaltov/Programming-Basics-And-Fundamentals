using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vehiclesForSelling = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();
            int soldVehicles = 0;

            while (!input.Equals("End of customers!"))
            {
                string[] tokens = input.Split(' ');
                string vehicleType = tokens[0];
                int neededSeats = int.Parse(tokens[2]);
                char searchedSymbol = vehicleType.ToLower()[0];
                bool sold = false;

                for (int i = 0; i < vehiclesForSelling.Count; i++)
                {
                    char currentSymbol = vehiclesForSelling[i][0];
                    int seats = int.Parse(vehiclesForSelling[i].Substring(1));

                    if (currentSymbol == searchedSymbol && neededSeats == seats)
                    {
                        sold = true;
                        soldVehicles++;
                        vehiclesForSelling.RemoveAt(i);
                        break;
                    }
                }

                if (sold)
                {
                    int price = searchedSymbol * neededSeats;

                    Console.WriteLine($"Yes, sold for {price}$");
                }
                else
                {
                    Console.WriteLine("No");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Vehicles left: " + string.Join(", ", vehiclesForSelling));
            Console.WriteLine($"Vehicles sold: {soldVehicles}");
        }
    }
}
