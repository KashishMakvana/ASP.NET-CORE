using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Bank_Account
    {
        int Account_No, Account_Balance;
        string Email, User_Name, Account_Type;

        public void GetAccountDetails()
        {
            Console.Write("Enter the Account Number:");
            Account_No = int.Parse(Console.ReadLine());

            Console.Write("Enter User Name:");
            this.User_Name = Console.ReadLine();


            Console.Write("Enter Email:");
            this.Email = Console.ReadLine();


            Console.Write("Enter Account Type:");
            this.Account_Type = Console.ReadLine();


            Console.Write("Enter Account Balance : ");
            this.Account_Balance = int.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n");
            Console.WriteLine("******** Bank Account Details **********");
            Console.WriteLine("Account Number : " + Account_No);
            Console.WriteLine("User Name : " + User_Name);
            Console.WriteLine("Email Address : " + Email);
            Console.WriteLine("Account Type : " + Account_Type);
            Console.WriteLine("Account Balance:" + Account_Balance);
        }
    }
}
