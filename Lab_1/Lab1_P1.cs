using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Candidate
    {
        int Id, Age;
        String Name;
        double Height, Weight;

        public void GetCandidateDetails()
        {
            Console.Write("Enter the Candidate Id:");
            this.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Candidate Name:");
            this.Name = Console.ReadLine();


            Console.Write("Enter Candidate Age:");
            this.Age = int.Parse(Console.ReadLine());


            Console.Write("Enter Candidate Height:");
            this.Height = double.Parse(Console.ReadLine());


            Console.Write("Enter Candidate Weight:");
            this.Weight = double.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("\n");
            Console.WriteLine("******** Candidate Details **********");
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Height : " + Height);
            Console.WriteLine("Weight :" + Weight);
        }
    }
}
