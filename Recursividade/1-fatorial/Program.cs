using System;
class Program
{
    static void Main(string[] args)
    {
        int n = 15; 
        double fatorial = Fatorial(n);
        Console.WriteLine($"O fatorial de {n} é {fatorial}");
    }

    static int Fatorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Fatorial(n - 1);
    }
}