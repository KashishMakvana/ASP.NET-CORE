using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Distance
    {
        double dist1, dist2, dist3;
        public Distance(double dist1, double dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }
        public void Addition()
        {
            dist3 = dist1 + dist2;
        }
        public void Display()
        {
            Console.WriteLine("Addtion of two Distance: " + dist3);
        }
    }
}
