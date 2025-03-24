using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Lab_2
//{
//    internal class Lab2_P8
//    {
//        public void Lab2_p8()
//        { 
//            static void Main(string[] args) 
//            {
//                try
//                {
//                    Console.Write("Enter a number: ");
//                    int number = int.Parse(Console.ReadLine());

//                    CheckEvenNumber(number);

//                    Console.WriteLine("The number is even.");
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Input is not a valid integer.");
//                }
//                catch (NotEvenNumberException ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//            static void CheckEvenNumber(int number)
//            {
//                if (number % 2 != 0)
//                {
//                    throw new NotEvenNumberException("The number is not even.");
//                }
//            }
//        }
//    }
//}
using System;

class Lab2_P8
{
    public  void Lab2_p8()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            CheckEvenNumber(number);

            Console.WriteLine("The number is even.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a valid integer.");
        }
        catch (NotEvenNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void CheckEvenNumber(int number)
    {
        if (number % 2 != 0)
        {
            throw new NotEvenNumberException("The number is not even.");
        }
    }
}

public class NotEvenNumberException : Exception
{
    public NotEvenNumberException(string message) : base(message)
    {
    }
}
