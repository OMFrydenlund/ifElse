using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    class AddNumbers
    {
        public int Num1 = 10;
        public int Num2 = 20;

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public void SumUp()
        {
            int sum = Add(Num1, Num2);
            Console.WriteLine($"The sum of {Num1} and {Num2} is: {sum}");
        }

        public static void AddRun()
        {
            AddNumbers additionInstance = new AddNumbers();
            additionInstance.SumUp();
        }
    }
}

