using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class IfElse
{
    public IfElse(int oddNumber, int evenNumber)
    {
        OddNumber = oddNumber;
        EvenNumber = evenNumber;
    }

    public int OddNumber { get; set; }
    public int EvenNumber { get; set; }

    public static void EqualChecker()
    {
        IfElse Instance = new IfElse(5, 10);
        EqualResponse(Instance.OddNumber, Instance.EvenNumber);
    }


    public static void EqualResponse(int oddNumber, int evenNumber)
    {
        if (oddNumber == evenNumber)
        {
            Console.WriteLine($"{oddNumber} is equal to {evenNumber}");
        }
        else
        {
            Console.WriteLine($"{oddNumber} is not equal to {evenNumber}");
        }
    }
}


