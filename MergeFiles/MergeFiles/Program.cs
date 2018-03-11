using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstInputLines = File.ReadAllLines("firstInput.txt").ToList();
            List<string> secondInputLines = File.ReadAllLines("secondInput.txt").ToList();
            List<string> mergedOutput = new List<string>();
            int maxCount = Math.Max(firstInputLines.Count, secondInputLines.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i < firstInputLines.Count)
                    mergedOutput.Add(firstInputLines[i]);
                if (i < secondInputLines.Count)
                    mergedOutput.Add(secondInputLines[i]);
            }

            File.WriteAllLines("output.txt", mergedOutput);
        }
    }
}
