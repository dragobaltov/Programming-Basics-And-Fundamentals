using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = new string[] 
            {
                "Two households, both alike in dignity,",
                "In fair Verona, where we lay our scene,",
                "From ancient grudge break to new mutiny,",
                "Where civil blood makes civil hands unclean.",
                "From forth the fatal loins of these two foes",
                "A pair of star-cross'd lovers take their life;",
                "Whose misadventured piteous overthrows",
                "Do with their death bury their parents' strife."
            };

            File.WriteAllLines("input.txt", inputLines);
            string[] outputLines = new string[inputLines.Length];
            int counter = 1;

            for (int i = 1; i < inputLines.Length; i += 2)
            {
                outputLines[i - counter] = inputLines[i];
                counter++;
            }

            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
