using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double avarageGrade = 0.0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                avarageGrade += grade;
                if (grade >= 2 && grade <= 2.99)
                {
                    counter1++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    counter2++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    counter3++;
                }
                else if (grade >= 5)
                {
                    counter4++;
                }
            }
            Console.WriteLine($"Top students: {counter4 / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counter3 / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counter2 / students * 100:F2}%");
            Console.WriteLine($"Fail: {counter1 / students * 100:F2}%");
            Console.WriteLine($"Average: {avarageGrade / students:F2}");
        }
    }
}
