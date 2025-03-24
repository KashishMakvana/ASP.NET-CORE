using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P10
    {
        public void Lab2_p10()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            char changedChar = ChangeCase(inputChar);

            Console.WriteLine("The changed case character is: " + changedChar);
        }
        char ChangeCase(char c)
        {
            if (char.IsUpper(c))
            {
                return char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                return char.ToUpper(c);
            }
            else
            {
                return c; 
            }
        }
    }
}
