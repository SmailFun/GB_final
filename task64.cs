using System;

class Program
{
    static void Main()
    {
        int N = 5; 
        PrintNumbersFromNTo1(N);
    }

    static void PrintNumbersFromNTo1(int N)
    {
        if (N < 1)
            return;
        
        Console.Write(N);
        if (N > 1)
            Console.Write(", ");
        
        PrintNumbersFromNTo1(N - 1);
    }
}