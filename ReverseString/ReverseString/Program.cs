﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }
    }
}
