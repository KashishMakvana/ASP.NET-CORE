using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Lab3_P1
    {   
            int sum = 0;
            float result = 0;
            public void Addition(int n1, int n2)
            {
                sum = n1 + n2;
                Console.WriteLine("Sum of Two Integer Number is  : " + sum);
            }

           public void Addition(float n1, float n2) 
            {
                result = n1 + n2;
                Console.WriteLine("Sum of Two Float Number is  : " + result);
            }
    }
}
