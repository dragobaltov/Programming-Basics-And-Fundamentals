using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentsData = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentsData.ContainsKey(name))
                {
                    studentsData.Add(name, new List<double>());
                }

                studentsData[name].Add(grade);
            }

            foreach (var item in studentsData)
            {
                string name = item.Key;
                List<double> grades = item.Value;
                double averageGrade = 0;

                Console.Write(name + " -> ");
                for (int i = 0; i < grades.Count; i++)
                {
                    Console.Write($"{grades[i]:F2} ");
                    averageGrade += grades[i];
                }
                averageGrade /= grades.Count;
                Console.WriteLine($"(avg: {averageGrade:F2})");
            }
        }
    }
}
