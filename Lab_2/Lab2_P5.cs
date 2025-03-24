using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab2_P5
    {
        public void Lab2_p5()
        {
            string name = "Darshan";
            string uni = "University";

            Console.WriteLine($"Length of {name} : " + name.Length);

            Console.WriteLine("String in Upper Case : " + name.ToUpper());
            Console.WriteLine("String in Lower Case : " + name.ToLower());
            string joinedStr = string.Concat(name, uni);
            Console.WriteLine("Joined String name and uni: " + joinedStr);

            Boolean result1 = name.Equals(uni);
            Console.WriteLine(result1);
            Console.WriteLine("Substring from the name : " + name.Substring(3));
            Console.WriteLine("remove string : " + name.Remove(5));

            Console.WriteLine("replace sting : " + uni.Replace("y", "Y"));
        }

    }
}
