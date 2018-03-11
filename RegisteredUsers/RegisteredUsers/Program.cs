using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " },
                StringSplitOptions.RemoveEmptyEntries);
            var nameAndDate = new Dictionary<string, DateTime>();

            while (input[0] != "end")
            {
                string name = input[0];
                DateTime date = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nameAndDate.Add(name, date);

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            nameAndDate = nameAndDate.Reverse().OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var result = new Dictionary<string, DateTime>();

            foreach (var item in nameAndDate.Take(5))
            {
                result.Add(item.Key, item.Value);
            }

            foreach (var item in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
