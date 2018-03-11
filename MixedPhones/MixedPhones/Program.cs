using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, long> phonebook = new Dictionary<string, long>();

            while (input[0] != "Over")
            {
                string name = input[0];
                string number = input[1];
                long numberValue;

                if (long.TryParse(number, out numberValue))
                {
                    phonebook.Add(name, numberValue);
                }
                else
                {
                    long nameToNumber = long.Parse(name);
                    phonebook.Add(number, nameToNumber);
                }

                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            SortedDictionary<string, long> result = new SortedDictionary<string, long>();

            foreach (KeyValuePair<string, long> item in phonebook)
            {
                result.Add(item.Key, item.Value);
            }

            foreach (KeyValuePair<string, long> item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
