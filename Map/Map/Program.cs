using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Program
    {
        public static Dictionary<int, int[]> map = new Dictionary<int, int[]>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ReadingAndPrintingMap(n);

            Console.WriteLine($"Max average sum = {MinAverageSum(map)}");
        }

        public static void ReadingAndPrintingMap(int n)
        {
            for (int i = 0; i < n; i++)
            {
                map.Add(i, new int[n]);
                for (int j = 0; j < n; j++)
                {
                    map[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(map[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double MinAverageSum(Dictionary<int, int[]> map)
        {
            double maxAvgSum = double.MinValue;

            for (int i = 0; i < map.Count; i++)
            {
                double currentAvgSum = 0;
                for (int j = 0; j < map[i].Length; j++)
                {
                    currentAvgSum += map[i][j];
                }
                currentAvgSum /= map[i].Length;

                if (currentAvgSum > maxAvgSum)
                    maxAvgSum = currentAvgSum;
            }

            return maxAvgSum;
        }
    }
}
