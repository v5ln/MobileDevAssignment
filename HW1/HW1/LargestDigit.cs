using System;
namespace HW1
{
    public class LargestDigit
    {
        public void largest()
        {
            // as we use in reverse function the remainder we will use it here also
            // to take the digit from the number to compair it

            int number;
            int remainder;
            int largest;

            Console.WriteLine("insert your number");
            number = Convert.ToInt32(Console.ReadLine());

            largest = number % 10;
            number /= 10;

            while (number > 0)
            {
                remainder = number % 10;
                if (remainder > largest)
                {
                    largest = remainder;
                }
                number /= 10;
            }


            Console.WriteLine("The Largest Number is: " + largest);
        }
    }
}
