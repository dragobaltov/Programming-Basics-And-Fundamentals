﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double leftSum = 0.0;
            double rightSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                leftSum += number;
            }
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                rightSum += number;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
