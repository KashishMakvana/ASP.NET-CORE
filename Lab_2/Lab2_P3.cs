using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Sum
    {
        public abstract void SumOfTwo(int n1, int n2);
        public abstract void SumOfThree(int n1, int n2,int n3);
    }

    public class Calculate : Sum
    {
        
        public override void SumOfTwo(int n1, int n2)
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine("Sum Of two number : " + sum);
            //return n1+n2;
        }
        public override void SumOfThree(int n1, int n2,int n3)
        {
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            int sum = n1 + n2 + n3;
            Console.WriteLine("Sum Of two number : " +sum);
            //return SumOfThree(n1,n2,n3);
        }


    }
}
