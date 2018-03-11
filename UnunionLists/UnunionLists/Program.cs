using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < currentList.Count; j++)
                {
                    bool contain = primalList.Contains(currentList[j]);
                    if (contain)
                    {
                        for (int k = 0; k < primalList.Count; k++)
                        {
                            if (primalList[k] == currentList[j])
                            {
                                primalList.RemoveAt(k);
                                k--;
                            }
                        }
                    }
                    else
                    {
                        primalList.Add(currentList[j]);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
