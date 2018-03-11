using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubles = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            string[] separated = doubles.Split(' ');
            double[] array = new double[separated.Length];

            ConvertingAndMultiplying(doubles, p, separated, array);
            DisplayingOnConsole(doubles, p, separated, array);
        }

        static void ConvertingAndMultiplying(string doubles, double p, string[] separated, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(separated[i]);
                array[i] *= p;
            }
        }

        static void DisplayingOnConsole(string doubles, double p, string[] separated, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
