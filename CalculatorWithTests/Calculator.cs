using System;
using System.Collections.Generic;
using System.Text;




namespace CalculatorWithTests
{
    public class Calculator
    {
       public int Add(int number1, int number2)
        {
            return (number1 + number2);
        }


        public double Subtract(double minuend,  double subtrahend)
        {
            return(minuend-subtrahend);
        }

        public long  Multiply(long factor1,long factor2)
        {
            return(factor1 * factor2);
        }

        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        public int factorial(int number1)
        {
            int fact = 1;
            for (int i = 1; i <= number1; i++)

            {
                fact = fact * i;
            }
            return fact;       
        }  

    }
}
