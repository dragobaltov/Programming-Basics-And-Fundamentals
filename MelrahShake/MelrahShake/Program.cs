using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern != "")
            {
                if (text.Contains(pattern))
                {
                    int startIndex = text.IndexOf(pattern);
                    int endIndex = startIndex + pattern.Length;
                    text = NewText(text, startIndex, endIndex);

                    if (text.Contains(pattern))
                    {
                        int startIndex2 = text.LastIndexOf(pattern);
                        int endIndex2 = startIndex2 + pattern.Length;
                        text = NewText(text, startIndex2, endIndex2);

                        Console.WriteLine("Shaked it.");
                        pattern = NewPattern(pattern);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");

            Console.WriteLine(text);
        }

        static string NewPattern(string pattern)
        {
            int indexToRemove = pattern.Length / 2;
            string newPattern = "";

            for (int i = 0; i < indexToRemove; i++)
            {
                newPattern += pattern[i];
            }
            for (int i = indexToRemove + 1; i < pattern.Length; i++)
            {
                newPattern += pattern[i];
            }

            return newPattern;
            
        }

        static string NewText(string text, int startIndex, int endIndex)
        {
            string newText = "";

            for (int i = 0; i < startIndex; i++)
            {
                newText += text[i];
            }
            for (int i = endIndex; i < text.Length; i++)
            {
                newText += text[i];
            }

            return newText;
        }
    }
}
