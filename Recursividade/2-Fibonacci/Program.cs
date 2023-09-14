using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 40; 
        double fibonacci = Fibonacci(n);
        Console.WriteLine($"O valor do {n}º número da sequência de fibonacci é: {fibonacci}");
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        else
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
    }
}