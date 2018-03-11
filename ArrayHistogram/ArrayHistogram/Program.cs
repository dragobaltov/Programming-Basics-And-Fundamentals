using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static string[] array;
        static int countOfStrings;

        static void Main(string[] args)
        {
            array = Console.ReadLine().Split(' ').ToArray();
            countOfStrings = array.Length;
            List<int> numbers = new List<int>();
            List<string> words = new List<string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!words.Contains(array[i]))
                {
                    words.Add(array[i]);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                string currentElement = array[i];
                int counter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (currentElement == array[j] && currentElement != "")
                    {
                        counter++;
                        array[j] = "";
                    }
                }
                if (counter != 0)
                    numbers.Add(counter);
            }

            BubbleSortForTwoLists(numbers, words);
            PrintingResult(numbers, words);
        }

        static void BubbleSortForTwoLists(List<int> counters, List<string> words)
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < counters.Count - 1; i++)
                {
                    if (counters[i] < counters[i + 1])
                    {
                        int helpNumbers = counters[i];
                        string helpStrings = words[i];
                        counters[i] = counters[i + 1];
                        counters[i + 1] = helpNumbers;
                        words[i] = words[i + 1];
                        words[i + 1] = helpStrings;
                        change = true;
                    }
                    else if (counters[i] == counters[i + 1])
                    {

                    }
                }
            } while (change);
        }

        static void PrintingResult(List<int> counters, List<string> words)
        {
            for (int i = 0; i < counters.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {counters[i]} times ({(counters[i] * 1.0 / countOfStrings) * 100:F2}%)");
            }
        }
    }
}
