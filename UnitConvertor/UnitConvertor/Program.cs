using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "m" && outputUnit == "mm")
            {
                Console.WriteLine($"{r * 1000:F8} mm");
            }
            else if (inputUnit == "m" && outputUnit == "cm")
            {
                Console.WriteLine($"{r * 100:F8} cm");
            }
            else if (inputUnit == "m" && outputUnit == "mi")
            {
                Console.WriteLine($"{r * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "m" && outputUnit == "in")
            {
                Console.WriteLine($"{r * 39.3700787:F8} in");
            }
            else if (inputUnit == "m" && outputUnit == "km")
            {
                Console.WriteLine($"{r * 0.001:F8} km");
            }
            else if (inputUnit == "m" && outputUnit == "ft")
            {
                Console.WriteLine($"{r * 3.2808399:F8} ft");
            }
            else if (inputUnit == "m" && outputUnit == "yd")
            {
                Console.WriteLine($"{r * 1.0936133:F8} yd");
            }
            else if (inputUnit == "mm" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 1000:F8} m");
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 10:F8} cm");
            }
            else if (inputUnit == "mm" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 1000 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "mm" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 1000 * 39.3700787:F8} in");
            }
            else if (inputUnit == "mm" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 1000 * 0.001:F8} km");
            }
            else if (inputUnit == "mm" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 1000 * 3.2808399:F8} ft");
            }
            else if (inputUnit == "mm" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 1000 * 1.0936133:F8} yd");
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 100:F8} m");
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                Console.WriteLine($"{r * 10:F8} mm");
            }
            else if (inputUnit == "cm" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 100 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "cm" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 100 * 39.3700787:F8} in");
            }
            else if (inputUnit == "cm" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 100 * 0.001:F8} km");
            }
            else if (inputUnit == "cm" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 100 * 3.2808399:F8} ft");
            }
            else if (inputUnit == "cm" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 100 * 1.0936133:F8} yd");
            }
            else if (inputUnit == "mi" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 0.000621371192:F8} m");
            }
            else if (inputUnit == "mi" && outputUnit == "mm")
            {
                Console.WriteLine($"{r / 0.000621371192 * 1000:F8} mm");
            }
            else if (inputUnit == "mi" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 0.000621371192 * 100:F8} cm");
            }
            else if (inputUnit == "mi" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 0.000621371192 * 39.3700787:F8} in");
            }
            else if (inputUnit == "mi" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 0.000621371192 * 0.001:F8} km");
            }
            else if (inputUnit == "mi" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 0.000621371192 * 3.2808399:F8} ft");
            }
            else if (inputUnit == "mi" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 0.000621371192 * 1.0936133:F8} yd");
            }
            else if(inputUnit == "in" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 39.370078:F8} m");
            }
            else if (inputUnit == "in" && outputUnit == "mm")
            { 
                Console.WriteLine($"{r / 39.3700787 * 1000:F8} mm");
            }
            else if (inputUnit == "in" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 39.3700787 * 100:F8} cm");
            }
            else if (inputUnit == "in" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 39.3700787 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "in" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 39.3700787 * 0.001:F8} km");
            }
            else if (inputUnit == "in" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 39.3700787 * 3.2808399:F8} ft");
            }
            else if (inputUnit == "in" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 39.3700787 * 1.0936133:F8} yd");
            }
            else if(inputUnit == "km" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 0.001:F8} m");
            }
            else if (inputUnit == "km" && outputUnit == "mm")
            {
                Console.WriteLine($"{r / 0.001 * 1000:F8} mm");
            }
            else if (inputUnit == "km" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 0.001 * 100:F8} cm");
            }
            else if (inputUnit == "km" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 0.001 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "km" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 0.001 * 39.3700787:F8} in");
            }
            else if (inputUnit == "km" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 0.001 * 3.2808399:F8} ft");
            }
            else if (inputUnit == "km" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 0.001 * 1.0936133:F8} yd");
            }
            else if(inputUnit == "ft" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 3.2808399:F8} m");
            }
            else if (inputUnit == "ft" && outputUnit == "mm")
            { 
                Console.WriteLine($"{r / 3.2808399 * 1000:F8} mm");
            }
            else if (inputUnit == "ft" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 3.2808399 * 100:F8} cm");
            }
            else if (inputUnit == "ft" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 3.2808399 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "ft" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 3.2808399 * 39.3700787:F8} in");
            }
            else if (inputUnit == "ft" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 3.2808399 * 0.001:F8} km");
            }
            else if (inputUnit == "ft" && outputUnit == "yd")
            {
                Console.WriteLine($"{r / 3.2808399 * 1.0936133:F8} yd");
            } 
            else if(inputUnit == "yd" && outputUnit == "m")
            {
                Console.WriteLine($"{r / 1.0936133:F8} m");
            }
            else if (inputUnit == "yd" && outputUnit == "mm")
            {
                Console.WriteLine($"{r / 1.0936133 * 1000:F8} mm");
            }
            else if (inputUnit == "yd" && outputUnit == "cm")
            {
                Console.WriteLine($"{r / 1.0936133 * 100:F8} cm");
            }
            else if (inputUnit == "yd" && outputUnit == "mi")
            {
                Console.WriteLine($"{r / 1.0936133 * 0.000621371192:F8} mi");
            }
            else if (inputUnit == "yd" && outputUnit == "in")
            {
                Console.WriteLine($"{r / 1.0936133 * 39.3700787:F8} in");
            }
            else if (inputUnit == "yd" && outputUnit == "km")
            {
                Console.WriteLine($"{r / 1.0936133 * 0.001:F8} km");
            }
            else if (inputUnit == "yd" && outputUnit == "ft")
            {
                Console.WriteLine($"{r / 1.0936133 * 3.2808399:F8} ft");
            }
            else if(inputUnit == "m" && outputUnit == "m")
            {
                Console.WriteLine($"{r:F8} m");
            }
            else if (inputUnit == "mm" && outputUnit == "mm")
            {
                Console.WriteLine($"{r:F8} mm");
            }
            else if (inputUnit == "cm" && outputUnit == "cm")
            {
                Console.WriteLine($"{r:F8} cm");
            }
            else if (inputUnit == "in" && outputUnit == "in")
            {
                Console.WriteLine($"{r:F8} in");
            }
            else if (inputUnit == "km" && outputUnit == "km")
            {
                Console.WriteLine($"{r:F8} km");
            }
            else if (inputUnit == "ft" && outputUnit == "ft")
            {
                Console.WriteLine($"{r:F8} ft");
            }
            else if (inputUnit == "yd" && outputUnit == "yd")
            {
                Console.WriteLine($"{r:F8} yd");
            }
            else if (inputUnit == "mi" && outputUnit == "mi")
            {
                Console.WriteLine($"{r:F8} mi");
            }
        }

    }

}