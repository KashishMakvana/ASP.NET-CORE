using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Student
    {
        int Enrollment_No, Semester;
        float CPI, SPI;
        string Student_Name;

        public Student()
        {
            Console.Write("Enter the Enrollment No:");
            Enrollment_No = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name:");
            Student_Name = Console.ReadLine();


            Console.Write("Enter Semester:");
            Semester = int.Parse(Console.ReadLine());


            Console.Write("Enter CPI :");
            CPI = float.Parse(Console.ReadLine());


            Console.Write("Enter SPI : ");
            SPI = float.Parse(Console.ReadLine());
        }


        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n");
            Console.WriteLine("******** Student Details **********");
            Console.WriteLine("Enrollment Number : " + Enrollment_No);
            Console.WriteLine("Student Name : " + Student_Name);
            Console.WriteLine("Semester : " + Semester);
            Console.WriteLine("CPI : " + CPI);
            Console.WriteLine("SPI:" + SPI);
        }
    }
}
