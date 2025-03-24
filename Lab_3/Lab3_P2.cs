using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab3_P2
    {
        float area;
        public void areaOfShape(int l)
        {
            area = l * l;
            Console.WriteLine("Area of Square is : "+area);
        }

        public void areaOfShape(int l ,int b)
        {
            area = l * b;
            Console.WriteLine("Area of Rectangle is : " + area);
        }
    }
}
