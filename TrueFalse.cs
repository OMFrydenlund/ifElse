using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class TrueFalse
    {
        public TrueFalse(int a, int b)
        {
            FirstNumber = a;
            SecondNumber = b;
            int sum = a + b;
        }

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public static void BoolChecker()
        {
            TrueFalse instance = new TrueFalse(15, 32);
            bool result = TrueFalseResponse(instance.FirstNumber, instance.SecondNumber);
            Console.WriteLine(result);
        }

        public static bool TrueFalseResponse(int a, int b)
        {
            int sum = a + b;

            if (sum  == 30)
                return true;
            else
                return false;
        }
    }
}
