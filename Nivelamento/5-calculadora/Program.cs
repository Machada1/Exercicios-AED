using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples em C#");
            
            Console.Write("Digite a operação (+, -, *, /): ");
            char operacao = Console.ReadLine()[0];
            
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            
            double resultado = 0.0;

            switch (operacao)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case '/':
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
