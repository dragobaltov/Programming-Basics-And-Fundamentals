using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();

            while (state != "collapse")
            {
                string fiction = Console.ReadLine();

                while (fiction != "")
                {
                    while (state.Contains(fiction))
                    {
                        int index = state.IndexOf(fiction);
                        state = state.Remove(index, fiction.Length);
                    }

                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0)
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                }

                if (state == "")
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    state = RemovingBlankSpaces(state);
                    Console.WriteLine(state);
                }
                
                state = Console.ReadLine();
            }
        }

        static string RemovingBlankSpaces(string state)
        {
            string[] tokens = state.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", tokens);
        }
    }
}
