
using System;
using System.Collections;

class Progarm8
{
    public delegate int MyDelegate(int x, int y);
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Sub(int x, int y)
    {
        return x - y;
    }
    public static int Mul(int x, int y)
    {
        return x * y;
    }
    public static int Div(int x, int y)
    {
        return x / y;
    }
}