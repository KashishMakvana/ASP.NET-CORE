using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class AreaOfRectangle
    {
        double length, breadth;
        public AreaOfRectangle()
        {
            Console.Write("Enter the lenghth:");
            length = double.Parse(Console.ReadLine());

            Console.Write("Enter Breath:");
            breadth = double.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            double area = this.length * this.breadth;
            Console.WriteLine("Area of Reactangle is : " + area);
        }
    }
}
