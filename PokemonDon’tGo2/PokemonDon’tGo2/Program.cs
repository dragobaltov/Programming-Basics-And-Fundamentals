using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> elements = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long sumOfRemovedElements = 0;

            while (elements.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long removedElement = 0;

                if (index < 0)
                {
                    removedElement = elements[0];
                    elements[0] = elements[elements.Count - 1];
                }
                else if (index >= elements.Count)
                {
                    removedElement = elements[elements.Count - 1];
                    elements[elements.Count - 1] = elements[0];
                }
                else
                {
                    removedElement = elements[index];
                    elements.RemoveAt(index);
                }

                elements = NewList(elements, removedElement);
                sumOfRemovedElements += removedElement;
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        static List<long> NewList(List<long> elements, long removedElement)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] <= removedElement)
                {
                    elements[i] += removedElement;
                }
                else
                {
                    elements[i] -= removedElement;
                }
            }

            return elements;
        }
    }
}
