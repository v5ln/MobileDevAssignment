using System;
namespace HW1
{
    public class FirstInt
    {
        public void firstint()
        {
            // here we will see the ascii number for each character and see if it btween 1 and 0
            Console.WriteLine("insert your text");
            string text = Console.ReadLine();
            string firstnumber = "";
            for (int i = 0; i < text.Length; i++)
                {
                    firstnumber = search(i, text, text.Length);
                    if (firstnumber != "")
                    {
                        break;
                    }
                }
            if (firstnumber == "")
            {
                Console.WriteLine("There is no intger in the text");
            }
            else
            {
                Console.WriteLine("The First Number is: " + firstnumber);
            }
        }
        private string search(int index, string text, int length)
        {
            if (index < length && text[index] < 58 && text[index] > 47)
            {
                if (index < length){
                    return (text[index].ToString() + search(index + 1, text, length));
                }
                else{
                    return (text[index].ToString());
                }
            }
            return "";
        }
    }
}
