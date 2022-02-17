using System;
namespace HW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LargestNumber largestNumber = new LargestNumber();
            Reverse reverse = new Reverse();
            LargestDigit largestDigit = new LargestDigit();
            FirstInt firstInt = new FirstInt();
            int choice;
            Console.WriteLine("Enter Your Choice:\n1-Largest Number\n2-Revered Number\n3-Largest Digit\n4-First Integer\n5-Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 5){
                switch (choice)
                {
                    case 1:
                        largestNumber.largest();
                        break;
                    case 2:
                        reverse.reverse();
                        break;
                    case 3:
                        largestDigit.largest();
                        break;

                    case 4:
                        firstInt.firstint();
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Try Again");
                        break;
                }
                Console.WriteLine("Enter Your Choice:\n1-Largest Number\n2-Revered Number\n3-Largest Digit\n4-First Integer\n5-Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
