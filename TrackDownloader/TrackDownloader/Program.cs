using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blacklistedWords = Console.ReadLine().Split(' ').ToList();
            List<string> newList = new List<string>();
            string fileName = Console.ReadLine();
            bool contain = false;

            while (fileName != "end")
            {
                if (!Condition(blacklistedWords, newList, fileName, contain))
                {
                    newList.Add(fileName);
                }

                fileName = Console.ReadLine();
            }

            PrintingNewList(newList);
        }

        static bool Condition(List<string> blacklistedWords, List<string> newList, string fileName, bool contain)
        {
            for (int i = 0; i < blacklistedWords.Count; i++)
            {
                if (fileName.Contains(blacklistedWords[i]))
                    return true;
            }

            return false;
        }

        static void PrintingNewList(List<string> newList)
        {
            newList.Sort();
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
        }
    }
}
