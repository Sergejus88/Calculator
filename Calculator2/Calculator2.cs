using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class Calculator
    {

        static void Main(string[] args)
        {

        }


        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static decimal SumDecimal3(decimal number1, decimal number2, decimal number3)
        {
            return (decimal)number1 + number2 + number3;
        }

        public static int Difference(int number1, int number2)
        {
            return number1 - number2;
        }


        public static int Product(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Quotient(int number1, int number2)
        {
            return (double)number1 / number2;
        
        }
    }
}



