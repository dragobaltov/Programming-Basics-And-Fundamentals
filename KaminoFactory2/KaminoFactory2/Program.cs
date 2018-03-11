using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var sequenceAndSum = new Dictionary<string, Tuple<int, int>>();
            var sequenceIndexAndLength = new Dictionary<string, Tuple<int, int>>();
            int sample = 0;

            while (!input.Equals("Clone them!"))
            {
                sample++;
                string clearSequence = GetSequncesWithoutSymbols(input);
                string longestOnes = GetLongestSequenceOfOnes(clearSequence);
                int currentLength = longestOnes.Length;
                int index = clearSequence.IndexOf(longestOnes);
                int sum = GetSum(clearSequence);

                if (!sequenceAndSum.ContainsKey(clearSequence))
                {
                    sequenceAndSum.Add(clearSequence, new Tuple<int, int>(sum, sample));
                    sequenceIndexAndLength.Add(clearSequence, new Tuple<int, int>(index, currentLength));
                }
                

                input = Console.ReadLine();
            }

            foreach (var item in sequenceIndexAndLength.OrderByDescending(s => s.Value.Item2)
                .ThenBy(s => s.Value.Item1).ThenByDescending(s => sequenceAndSum[s.Key].Item1).Take(1))
            {
                Console.WriteLine($"Best DNA sample {sequenceAndSum[item.Key].Item2} with sum: {sequenceAndSum[item.Key].Item1}.");
                Console.WriteLine(GetResult(item.Key));
            }
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

        static string GetLongestSequenceOfOnes(string sequence)
        {
            List<string> ones = sequence.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int maxLength = 0;

            for (int i = 0; i < ones.Count; i++)
            {
                if (ones[i].Length > maxLength)
                {
                    maxLength = ones[i].Length;
                }
            }

            return new string('1', maxLength);
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
    }
}
