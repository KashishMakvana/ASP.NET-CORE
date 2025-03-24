using Lab_3;
using System;
using static ABC;

class Progarm
{
    public static void Main(string[] args)
    {
        Lab3_P1 p1 = new Lab3_P1();
        p1.Addition(10, 20);
        p1.Addition(10.2f, 2.2f);

        Lab3_P2 p2 = new Lab3_P2();
        p2.areaOfShape(4);
        p2.areaOfShape(4, 5);


        RBI rbi = new RBI();
        RBI hdfc = new HDFC();
        RBI sbi = new SBI();
        RBI icici = new ICICI();

        rbi.CalculateInterest();
        hdfc.CalculateInterest();
        sbi.CalculateInterest();
        icici.CalculateInterest();

        Hospital h = new Hospital();
        Apollo a = new Apollo();
        Gokul_Superspeciality g = new Gokul_Superspeciality();
        Wockhardt w = new Wockhardt();

        h.HospitalDetails();
        a.HospitalDetails();
        g.HospitalDetails();
        w.HospitalDetails();

        Lab3_P6 p6 = new Lab3_P6();
        p6.Area(3);
        p6.Area(4, 3);
        p6.Area(5, true);

        ABC aBC = new ABC();
        Factorial factorialDelegate = new Factorial(CalculateFactorial);
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());
        int result = factorialDelegate(number);
        Console.WriteLine($"The factorial of {number} is {result}");


        Console.WriteLine("Enter number 1 : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2 : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Progarm8 progarm8 = new Progarm8();
        Progarm8.MyDelegate del = Progarm8.Add;
        Console.WriteLine(("Addition is : " + del(num1, num2)));

        del = Progarm8.Sub;
        Console.WriteLine(("Subtraction is :" + del(num1, num2)));

        del = Progarm8.Mul;
        Console.WriteLine("Multiplication is :" + (del(num1, num2)));

        del = Progarm8.Div;
        Console.WriteLine("Division is : " + (del(num1, num2)));


        TrafficDel yellowSignal = new TrafficDel(TrafficSignal.Yellow);
        TrafficDel greenSignal = new TrafficDel(TrafficSignal.Green);
        TrafficDel redSignal = new TrafficDel(TrafficSignal.Red);

        yellowSignal();
        greenSignal();
        redSignal();
    }
}
