using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = 0;
            int sumRemovedElements = 0;
            int removedElement = 0;
            

            while (distances.Count > 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElement = distances[0];
                    distances.RemoveAt(0);
                    distances.Insert(0, distances[distances.Count - 1]);
                }
                else if (index >= distances.Count)
                {
                    removedElement = distances[distances.Count - 1];
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(distances[0]);
                }
                else
                {
                    removedElement = distances[index];
                    distances.RemoveAt(index);
                }

                sumRemovedElements += removedElement;

                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= removedElement)
                    {
                        distances[i] += removedElement;
                    }
                    else
                    {
                        distances[i] -= removedElement;
                    }
                }
            }

            Console.WriteLine(sumRemovedElements);
        }
    }
}
