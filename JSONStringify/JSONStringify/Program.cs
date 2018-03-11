using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> studentsData = new List<Student>();

            while (input != "stringify")
            {
                string[] tokens = input.Split(new string[] { " : ", " -> ", " ->" }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                short age = short.Parse(tokens[1]);
                List<short> grades = new List<short>();
                if (tokens.Length > 2)
                {
                    grades = tokens[2].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(short.Parse).ToList();
                }
                Student student = Student.ReadStudent(name, age, grades);
                bool contain = false;

                for (int i = 0; i < studentsData.Count; i++)
                {
                    if (studentsData[i].Name == name && studentsData[i].Age == age)
                    {
                        studentsData[i].Grades.AddRange(grades);
                        contain = true;
                    }
                }

                if (!contain)
                    studentsData.Add(student);

                input = Console.ReadLine();
            }

            if (studentsData.Count != 0)
            {
                Console.Write("[");
            }
            for (int i = 0; i < studentsData.Count; i++)
            {
                Console.Write($"{{name:\"{studentsData[i].Name}\",age:{studentsData[i].Age}");
                if (studentsData[i].Grades.Count > 0)
                {
                    Console.Write($",grades:[{string.Join(", ", studentsData[i].Grades)}]}}");
                }
                else
                {
                    Console.Write(",grades:[]}");
                }
                if (i != studentsData.Count - 1)
                {
                    Console.Write(",");
                }
            }
            if (studentsData.Count != 0)
            {
                Console.Write("]");
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
