using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW1
{
    public class Reverse
    {
        private string numberToParse;

        public void reverse()
        {
            // the idea here is we gonna take the remainder of 10 of from the number
            // that equals last digit of number and put it in the front
            // after that we gonna divide the number by 10
            // to erase last digit of number 
            Console.WriteLine("Enter the number to be reversed: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder;
            int reverse = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverse *= 10 + remainder;
                number /= 10;
            }
            Console.WriteLine("The Reversed Number is: " + reverse);
        }
    }
}
