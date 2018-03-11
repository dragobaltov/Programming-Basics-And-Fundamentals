using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y") == true)
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") == true || word.EndsWith("ch") == true || word.EndsWith("s") == true || word.EndsWith("sh") == true || word.EndsWith("x") == true || word.EndsWith("z") == true)
            {
                word += "es";
            }
            else
            {
                word += "s";
            }

            Console.WriteLine(word);
        }
    }
}
