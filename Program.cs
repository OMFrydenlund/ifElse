using System;
using System.Diagnostics;
using ifElse;

//complete final task
//add user choice
//enjoy the chaotic process >:§
class Program
{
    static void Main()
    {
        ProgRun();
    }

    private static void ProgRun()
    {
        Console.Clear();
        Console.WriteLine("1.Add");
        Console.WriteLine("2.Check equal value");
        Console.WriteLine("3.Check true or false");
        Console.WriteLine(" (press 1 - 3)");
        var userInput = ParseInput(3, "Can't do that!");
        switch (userInput)
        {
            case 1:
                AddNumbers.AddRun();
                break;
            case 2:
                IfElse.EqualChecker();
                break;
            case 3:
                TrueFalse.BoolChecker();
                break;
        }

        static int ParseInput(int max, string errorMessage = "Number out of range!")
        {
            var input = Console.ReadLine();
            try
            {
                var number = int.Parse(input);
                if (number >= 0 && number <= max) return number;
                Console.WriteLine(errorMessage);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number, try again.");
            }
            return ParseInput(max);
        }
    }
}