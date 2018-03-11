using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> resultList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                List<int> sequence = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                if (resultList.Count == 0 || resultList[resultList.Count - 1] <= sequence[0])
                {
                    resultList.AddRange(sequence);
                }
                else
                {
                    for (int j = resultList.Count - 1; j >= 0; j--)
                    {
                        if (resultList[j] <= sequence[0])
                        {
                            for (int k = 0; k < sequence.Count; k++)
                            {
                                resultList.Insert(j + 1, sequence[k]);
                                j++;
                            }
                            break;
                        }
                    }
                }
                

                int previousNumber = resultList[0];

                for (int j = 0; j < resultList.Count; j++)
                {
                    if (resultList[j] < previousNumber)
                    {
                        for (int k = j; k < resultList.Count; k++)
                        {
                            resultList.RemoveAt(k);
                            k--;
                        }
                        break;
                    }
                    previousNumber = resultList[j];
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
