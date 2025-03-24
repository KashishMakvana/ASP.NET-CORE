using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Lab3_P6
    {
        double ans;
        public void Area(double l)
        {
            ans = l * l;
            Console.WriteLine("Area of Square : " + ans);
        }
        public void Area(double l, double w)
        {
            ans = l * w;
            Console.WriteLine("Area od Reactangle : " + ans);
        }
        public void Area(double radius, bool isCircle)
        {
            if (isCircle)
            {
                ans =  Math.PI * radius * radius;
                Console.WriteLine("Area od Circle : " + ans);
            }
            else
            {
                Console.WriteLine("Invalid argument for circle area calculation.");
            }
        }
    }
}
