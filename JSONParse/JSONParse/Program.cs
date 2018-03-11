using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            string[] tokens1 = input.Split(new string[] { "},{", "[{", "}]" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens1.Length; i++)
            {
                string[] tokens2 = tokens1[i]
                    .Split(new string[] { "name:", "age:", "grades:", "\"", "[", "]", ", ", "," },
                    StringSplitOptions.RemoveEmptyEntries);
                string name = tokens2[0];
                short age = short.Parse(tokens2[1]);
                List<short> grades = new List<short>();

                for (int j = 2; j < tokens2.Length; j++)
                {
                    short grade = short.Parse(tokens2[j]);
                    grades.Add(grade);
                }

                Student student = Student.ReadStudent(name, age, grades);
                students.Add(student);
            }

            foreach (var item in students)
            {
                Console.Write($"{item.Name} : {item.Age} -> ");
                if (item.Grades.Count == 0)
                {
                    Console.Write("None");
                }
                else
                {
                    Console.Write(string.Join(", ", item.Grades));
                }
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public short Age { get; set; }
        public List<short> Grades { get; set; }

        public static Student ReadStudent(string name, short age, List<short> grades)
        {
            return new Student
            {
                Name = name,
                Age = age,
                Grades = grades
            };
        }
    }
}
