using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P6
    {
        public void Lab2_p6()
        {
            string str;
            string result;
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    result = str[i].ToString().ToUpper();
                    Console.WriteLine(result);
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    result = str[i].ToString().ToLower();
                    Console.WriteLine(result);
                }
            }
        }
    }
}




