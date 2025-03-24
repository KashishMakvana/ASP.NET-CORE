using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal interface InterfaceCal
    {
        void Addition(int n1,int n2);
        void Subtraction(int n1,int n2);
    }
    class Result : InterfaceCal
    {
        public void Addition(int n1,int n2)
        {
            int sum = 0;
            sum = n1 + n2;
            Console.WriteLine("Addtion of two number : " +sum);
        }

        public void Subtraction(int n1, int n2)
        {
            int sub = 0;
            sub = n1 - n2;
            Console.WriteLine("Subtraction of two number : " + sub);
        }
    }
}
