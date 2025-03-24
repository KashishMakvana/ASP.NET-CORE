using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P2
    {
        public void Lab2_p2()
        {
            int[] intArray = new int[5] { 50, 40, 30, 20, 10 };
            int i = 0;
            int sum = 0;

            try
            {
                for (i = 0; i <= 5; i++)
                {
                    sum += intArray[i];
                }
                Console.WriteLine("Sum of array elements:" + sum);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}







