using System;
namespace HW1
{
    public class LargestNumber
    {
        public void largest()
        {
            Console.WriteLine("Enter how many numbers you would like to insert:");
            int count = Convert.ToInt32(Console.ReadLine());
            int largest;
            int number;

            if (count <= 0)
            {
                return;
            }

            Console.WriteLine("insert your number");
            largest = Convert.ToInt32(Console.ReadLine());
            count--;

            for (int i=0; i<count; i++)
            {
                Console.WriteLine("insert your number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > largest)
                {
                    largest = number;
                }
            }
            Console.WriteLine("The Largest Number is: " + largest);
        }
    }
}
