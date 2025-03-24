using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Account_Details
    {
        public int AccountNo;
        public string UserName;
        public double Principle, RateOfInerest, TimePeriod;
        public void GetAccountDetails()
        {
            Console.Write("Enter the Acocunt no:");
            AccountNo = int.Parse(Console.ReadLine());

            Console.Write("Enter the User Name:");
            UserName = Console.ReadLine();

            Console.Write("Enter the Principle:");
            Principle = double.Parse(Console.ReadLine());

            Console.Write("Enter the RateOfInerest:");
            RateOfInerest = double.Parse(Console.ReadLine());

            Console.Write("Enter the TimePeriod:");
            TimePeriod = double.Parse(Console.ReadLine());
        }
    }


    class Interest : Account_Details
    {
        public Interest()
        {
            GetAccountDetails();
        }
        public void DisplayInterest()
        {
            Console.WriteLine("Simple Interest : " + ((Principle * RateOfInerest *
            TimePeriod) / 100));
        }
    }
}
