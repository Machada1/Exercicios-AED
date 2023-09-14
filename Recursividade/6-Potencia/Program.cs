using System;

class Program
{
    static int PotenciacaoRecursiva(int a, int b)
    {

        if (b == 0)
        {
            return 1;
        }


        return a * PotenciacaoRecursiva(a, b - 1);
    }

    static void Main()
    {
        Console.Write("Digite a base (A): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o expoente (B): ");
        int b = int.Parse(Console.ReadLine());

        int resultado = PotenciacaoRecursiva(a, b);

        Console.WriteLine($"{a}^{b} = {resultado}");
    }
}
