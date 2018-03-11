using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "Dog")
                {
                    Dog dog = Dog.ReadDog(input);
                    dogs.Add(dog);
                }
                else if (tokens[0] == "Cat")
                {
                    Cat cat = Cat.ReadCat(input);
                    cats.Add(cat);
                }
                else if (tokens[0] == "Snake")
                {
                    Snake snake = Snake.ReadSnake(input);
                    snakes.Add(snake);
                }
                else
                {
                    if (dogs.Select(d => d.Name).Contains(tokens[1]))
                    {
                        Console.WriteLine(Dog.Sound);
                    }
                    else if (cats.Select(c => c.Name).Contains(tokens[1]))
                    {
                        Console.WriteLine(Cat.Sound);
                    }
                    else
                    {
                        Console.WriteLine(Snake.Sound);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in dogs)
            {
                Console.WriteLine($"Dog: {item.Name}, Age: {item.Age}, Number Of Legs: {item.NumberOfLegs}");
            }
            foreach (var item in cats)
            {
                Console.WriteLine($"Cat: {item.Name}, Age: {item.Age}, IQ: {item.IQ}");
            }
            foreach (var item in snakes)
            {
                Console.WriteLine($"Snake: {item.Name}, Age: {item.Age}, Cruelty: {item.CrueltyCoefficient}");
            }
        }

        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }

            public static string Sound
            {
                get
                {
                    return "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
                }
            }

            public static Dog ReadDog(string input)
            {
                string[] tokens = input.Split(' ');

                return new Dog
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    NumberOfLegs = int.Parse(tokens[3])
                };
            }
        }

        class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IQ { get; set; }

            public static string Sound
            {
                get
                {
                    return "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
                }
            }

            public static Cat ReadCat(string input)
            {
                string[] tokens = input.Split(' ');

                return new Cat
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    IQ = int.Parse(tokens[3])
                };
            }
        }

        class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }

            public static string Sound
            {
                get
                {
                    return "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
                }
            }

            public static Snake ReadSnake(string input)
            {
                string[] tokens = input.Split(' ');

                return new Snake
                {
                    Name = tokens[1],
                    Age = int.Parse(tokens[2]),
                    CrueltyCoefficient = int.Parse(tokens[3])
                };
            }
        }
    }
}
