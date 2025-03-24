using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Staff
    {
        string Name, Department, Designation;
        int Experience, Salary;

        public void GetInfo()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Post: ");
            Designation = Console.ReadLine();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Staff Name : " + Name);
            Console.WriteLine("Staff Designation:" + Designation);
        }

        public void OnlyHOD()
        {
            if (Designation.ToLower() == "hod")
            {
                DisplayInfo();
            }
        }
    }
}
