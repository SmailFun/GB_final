using System;

class Program
{
    static void Main()
    {
        int M = 1; 
        int N = 15; 
        int sum = SumOfNaturalNumbersInRange(M, N);
        Console.WriteLine(sum);
    }

    static int SumOfNaturalNumbersInRange(int M, int N)
    {
        if (M > N)
            return 0;
        
        return M + SumOfNaturalNumbersInRange(M + 1, N);
    }
}