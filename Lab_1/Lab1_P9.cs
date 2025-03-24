using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Furniture
    {
        string material;
        double price;

        public void GetInfo()
        {
            Console.WriteLine("Enter Material name : ");
            this.material = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            this.price = Convert.ToInt32(Console.ReadLine());
        }

        public void showInfo()
        {
            Console.WriteLine("Furniture Meterial Name : " + material);
            Console.WriteLine("Furniture Meterial Price : " + price);
        }
    }
    class Table : Furniture
    {
        int Height, Surface_Area;
        public void GetData()
        {
            base.GetInfo();
            Console.Write("Enter height: ");
            Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter surface area: ");
            Surface_Area = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            base.showInfo();
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Surface Area : " + Surface_Area);
        }
    }
}
