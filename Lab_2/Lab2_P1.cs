using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P1
    {
        public void Lab2_p1()
        {
            int num, ans = 0;
            try
            {
                Console.WriteLine("Enter a number for division");
                num = int.Parse(Console.ReadLine());
                ans = num / 0;
                Console.WriteLine("Answer of Division : " + ans);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Number can not divide by Zero");
            }
        }
    }
}
