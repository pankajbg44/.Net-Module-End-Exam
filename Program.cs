using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        double averageLength = CalculateAverageWordLength(input);

        Console.WriteLine("Average word length: {0}", Math.Round(averageLength, 3));
    }

    static double CalculateAverageWordLength(string input)
    {
        string[] words = input.Split(' ');
        int totalLength = 0;

        foreach (string word in words)
        {
            totalLength += word.Length;
        }

        return (double)totalLength / words.Length;
    }
}
