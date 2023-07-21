using System;

class Program {
    public static void Main (string[] args) {
        Console.WriteLine (getMaior(5, 13, 10));
    }

    public static int getMaior(int a,
        int b,
        int c)
    {
        return (a>b) ? ((a>c) ? a : c) : ((b>c) ? b : c);
    }
}