using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades2
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double counter2 = 0.0;
            double counter3 = 0.0;
            double counter4 = 0.0;
            double counter5 = 0.0;
            double averageGrade = 0.0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    counter2++;
                }
                else if (grade <= 3.99)
                {
                    counter3++;
                }
                else if (grade <= 4.99)
                {
                    counter4++;
                }
                else
                {
                    counter5++;
                }
                averageGrade += grade;
            }

            Console.WriteLine($"Top students: {counter5 / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counter4 / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counter3 / students * 100:F2}%");
            Console.WriteLine($"Fail: {counter2 / students * 100:F2}%");
            Console.WriteLine($"Average: {averageGrade / students:F2}");
        }
    }
}
