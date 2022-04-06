using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else if (number1 < number2)
            {
                return number1;
            }
            return number1;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else if (number1 < number2)
            {
                return number1;
            }
            return (int)number3; //conver ke int
        }
        public int FindMaximum(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number2;
            }
            else if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }
        public int FindMaximum(int number1, int number2, float number3)
        {
            if (number2 < number3)
            {
                return (int)number3;
            }
            else if (number2 > number3)
            {
                return (int)number3;
            }
            return number1; //Conver ke int
        }
    }
}
