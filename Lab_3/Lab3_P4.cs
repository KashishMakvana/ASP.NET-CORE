using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;



class ABC
{
    public delegate int Factorial(int num);
    public static int CalculateFactorial(int num)
    {
        int factorial = 1;
        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
