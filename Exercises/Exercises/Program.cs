using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Exercise> exercises = new List<Exercise>();

            while (input != "go go go")
            {
                Exercise exercise = Exercise.ReadExercise(input);
                exercises.Add(exercise);

                input = Console.ReadLine();
            }

            foreach (var item in exercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");

                int counter = 1;
                foreach (var problem in item.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }

        class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public string[] Problems { get; set; }

            public static Exercise ReadExercise(string input)
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeLink = tokens[2];
                string[] problems = tokens[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                return new Exercise
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeLink,
                    Problems = problems
                };
            }
        }
    }
}
