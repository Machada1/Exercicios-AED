using System;

class Program
{
    static void CalcularPotencia(ref int baseNumero, int expoente, out long resultado)
    {
        resultado = 1;
        for (int i = 0; i < expoente; i++)
        {
            resultado *= baseNumero;
        }
    }

    static void Main()
    {
        Console.Write("Digite a base (x): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Digite o expoente (y): ");
        int y = int.Parse(Console.ReadLine());

        long resultado;

        CalcularPotencia(ref x, y, out resultado);

        Console.WriteLine($"{x}^{y} = {resultado}");
    }
}
