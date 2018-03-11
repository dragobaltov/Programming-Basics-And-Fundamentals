using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine().Split('|').ToList();
            List<string> emptyList = new List<string>();

            for (int i = stringList.Count - 1; i >= 0; i--)
            {
                emptyList.Add((string.Join(" ",stringList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
            }

            Console.WriteLine(string.Join(" ", emptyList));
        }
    }
}
