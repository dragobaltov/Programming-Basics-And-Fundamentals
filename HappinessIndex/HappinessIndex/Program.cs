using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HappinessIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string happyPattern = @"(:\))|(:D)|(;\))|(:\*)|(:])|(;])|(:})|(;})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            string sadPattern = @"(:\()|(D:)|(;\()|(:\[)|(;\[)|(:{)|(;{)|(\):)|(:c)|(]:)|(];)";
            int happyFaces = 0;
            int sadFaces = 0;

            if (Regex.IsMatch(input, happyPattern))
            {
                happyFaces = Regex.Matches(input, happyPattern).Count;
            }
            if (Regex.IsMatch(input, sadPattern))
            {
                sadFaces = Regex.Matches(input, sadPattern).Count;
            }

            double happyIndex = happyFaces * 1.0 / sadFaces;
            happyIndex = Math.Round(happyIndex, 2);
            string face = FaceType(happyIndex);

            Console.WriteLine($"Happiness index: {happyIndex:F2} {face}");
            Console.WriteLine($"[Happy count: {happyFaces}, Sad count: {sadFaces}]");
        }

        static string FaceType(double index)
        {
            if (index >= 2)
            {
                return ":D";
            }
            else if(index > 1)
            {
                return ":)";
            }
            else if (index == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
        }
    }
}
