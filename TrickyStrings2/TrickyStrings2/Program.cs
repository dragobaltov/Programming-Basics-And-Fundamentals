using System;

class TrickyStrings
{
    static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());
        string result = String.Empty;
        string currentString = String.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            if (i == numberOfStrings - 1)
            {
                result += currentString;
            }
            else
            {
                result += currentString + delimiter;
            }
        }
            
        Console.WriteLine(result);
    }
}
