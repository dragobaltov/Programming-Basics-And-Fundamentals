using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] 
            { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '\'', '!', '?', ' ' },
             StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).Where(x => x.Length < 5)
             .Distinct().OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
