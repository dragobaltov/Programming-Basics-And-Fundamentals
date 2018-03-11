using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            string[] outputLines = new string[inputLines.Length];

            for (int i = 0; i < inputLines.Length; i++)
            {
                outputLines[i] = $"{i + 1}. " + inputLines[i];
            }

            for (int i = 0; i < outputLines.Length; i++)
            {
                Console.WriteLine(outputLines[i]);
            }
        }
    }
}
