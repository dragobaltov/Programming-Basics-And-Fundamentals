using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string command = String.Empty;
            string name = String.Empty;
            string number = String.Empty;
            

            while (command != "done")
            {
                command = Console.ReadLine();
                string[] commandArr = command.Split(' ');
                bool printName = false;
                bool printNumber = false;
                int sumOfDigits = 0;

                if (commandArr[0] == "call")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (commandArr[1] == names[i])
                        {
                            number = phoneNumbers[i];
                            printNumber = true;
                        }
                        else if (commandArr[1] == phoneNumbers[i])
                        {
                            name = names[i];
                            number = phoneNumbers[i];
                            printName = true;
                        }
                    }

                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] >= '0' && number[i] <= '9')
                        {
                            sumOfDigits += (number[i] - '0');
                        }
                    }

                    if (printNumber)
                    {
                        Console.WriteLine($"calling {number}...");
                    }
                    else if (printName)
                    {
                        Console.WriteLine($"calling {name}...");
                    }

                    if (sumOfDigits % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        Console.WriteLine($"call ended. duration: {sumOfDigits / 60:D2}:{sumOfDigits % 60:D2}");
                    }
                }
                else if (commandArr[0] == "message")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (commandArr[1] == names[i])
                        {
                            number = phoneNumbers[i];
                            printNumber = true;
                        }
                        else if (commandArr[1] == phoneNumbers[i])
                        {
                            name = names[i];
                            number = phoneNumbers[i];
                            printName = true;
                        }
                    }
                    
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (number[i] >= '0' && number[i] <= '9')
                        {
                            sumOfDigits += (number[i] - '0');
                        }
                    }

                    if (printNumber)
                    {
                        Console.WriteLine($"sending sms to {number}...");
                    }
                    else if (printName)
                    {
                        Console.WriteLine($"sending sms to {name}...");
                    }

                    if (sumOfDigits % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
            }
        }

        static int GetSumOfDigits(string number)
        {
            int sumOfDigits = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    sumOfDigits += (number[i] - '0');
                }
            }

            return sumOfDigits;
        }
    }
}
