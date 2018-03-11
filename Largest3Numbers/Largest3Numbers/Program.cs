using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list = list.OrderBy(x => -x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
