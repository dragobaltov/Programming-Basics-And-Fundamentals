using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> sequences = new List<string>();

            while (!input.Equals("Clone them!"))
            {
                sequences.Add(input);

                input = Console.ReadLine();
            }

            int bestLength = 0;
            int bestStartIndex = -1;
            string bestSequence = "";
            int bestSum = 0;

            for (int i = 0; i < sequences.Count; i++)
            {
                string clearSequence = GetSequncesWithoutSymbols(sequences[i]);
                List<string> sequencesOfOnes = clearSequence.Split(new char[] { '0' },
                StringSplitOptions.RemoveEmptyEntries).ToList();
                int maxLength = LongestSequenceOfOnes(sequencesOfOnes).Length;
                int startIndex = clearSequence.IndexOf(LongestSequenceOfOnes(sequencesOfOnes));
                int sum = GetSum(clearSequence);

                if (maxLength > bestLength)
                {
                    bestLength = maxLength;
                    bestStartIndex = startIndex;
                    bestSequence = sequences[i];
                    bestSum = sum;
                }
                else if (maxLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = maxLength;
                        bestStartIndex = startIndex;
                        bestSequence = sequences[i];
                        bestSum = sum;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (sum > bestSum)
                        {
                            bestLength = maxLength;
                            bestStartIndex = startIndex;
                            bestSequence = sequences[i];
                            bestSum = sum;
                        }
                    }
                }
            }

            int index = sequences.IndexOf(bestSequence);

            if (bestSequence != "")
            {
                Console.WriteLine($"Best DNA sample {index + 1} with sum: {bestSum}.");
                Console.WriteLine(GetResult(bestSequence));
            }
        }

        static string GetResult(string sequence)
        {
            string result = "";

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] != '!')
                {
                    result += sequence[i] + " ";
                }
            }

            return result;
        }

        static int GetSum(string text)
        {
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                sum += int.Parse(text[i].ToString());
            }

            return sum;
        }

        static string LongestSequenceOfOnes(List<string> sequences)
        {
            int maxLength = 0;
            string longestSequnce = "";

            for (int i = 0; i < sequences.Count; i++)
            {
                if (sequences[i].Length > maxLength)
                {
                    maxLength = sequences[i].Length;
                    longestSequnce = sequences[i];
                }
            }

            return longestSequnce;
        }

        static string GetSequncesWithoutSymbols(string sequence)
        {
            string newSequence = "";

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] != '!')
                {
                    newSequence += sequence[i];
                }
            }

            return newSequence;
        }
    }
}
