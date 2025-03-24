using System;
using System.Collections;

public delegate void TrafficDel();
class TrafficSignal
{
    public static void Yellow()
    {
        Console.WriteLine("Yellow Light Signal To Get Ready");
    }

    public static void Green()
    {
        Console.WriteLine("Green Light Signal To Go");
    }

    public static void Red()
    {
        Console.WriteLine("Red Light Signal To Stop");
    }
}

