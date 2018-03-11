using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(new char[] { ' ', '.', ',' }).Select(double.Parse).ToArray();
            List<double> wholeParts = new List<double>();
            List<double> decimalParts = new List<double>();
            int backIndex = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] != 0)
                {
                    wholeParts.Add(array[i]);
                }
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 1 && array[i] != 0)
                {
                    decimalParts.Add(array[i]);
                }
            }

            List<char> chars = ConvertingToChars(wholeParts, decimalParts);
            
            Console.WriteLine(string.Join("", chars));
        }

        static List<char> ConvertingToChars(List<double> integers, List<double> decimalParts)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < integers.Count; i++)
            {
                int integer = Convert.ToInt32(integers[i]);
                char ch = Convert.ToChar(integer);
                charList.Add(ch);
            }
            for (int i = 0; i < decimalParts.Count; i++)
            {
                int integer = Convert.ToInt32(decimalParts[i]);
                char ch = Convert.ToChar(integer);
                charList.Add(ch);
            }

            return charList;
        }
    }
}
