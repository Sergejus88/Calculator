using System;

namespace Calculator2
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.SumInt(1, 3));
            Console.WriteLine(Calculator.SumInt(1, 4));

            if (Calculator.SumInt(1, 4) == 5)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }   
}



