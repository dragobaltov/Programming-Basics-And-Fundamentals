using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                lines.Add(text);
            }

            string biggestPyramid = "";

            for (int i = 0; i < lines.Count; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char symbol = currentLine[j];
                    string pyramid = FindPyramid(lines, symbol, i);

                    if (pyramid.Length > biggestPyramid.Length)
                    {
                        biggestPyramid = pyramid;
                    }
                }
            }

            Console.WriteLine(biggestPyramid);
        }

        private static string FindPyramid(List<string> lines, char symbol, int line)
        {
            string pyramid = "" + symbol + "\r\n";
            int count = 3;

            for (int i = line + 1; i < lines.Count; i++)
            {
                string stringToFind = new string(symbol, count);

                if (lines[i].Contains(stringToFind))
                {
                    pyramid += stringToFind + "\r\n";
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }

            return pyramid;
        }
    }
}
