using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                string name = input[0];
                string number = input[2];
                int numberValue;

                if (int.TryParse(number, out numberValue))
                {
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, numberValue);
                    }
                    else
                    {
                        result[name] = numberValue;
                    }
                }
                else
                {
                    if (!result.ContainsKey(name))
                    {
                        if (result.ContainsKey(number))
                        {
                            result.Add(name, result[number]);
                        }
                    }
                    else
                    {
                        if (result.ContainsKey(number))
                        {
                            result[name] = result[number];
                        }
                    }
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
