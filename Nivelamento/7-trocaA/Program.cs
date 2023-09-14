using System;

namespace SubstituicaoDeLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            char[] caracteres = frase.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'A' || caracteres[i] == 'a')
                {
                    caracteres[i] = '&';
                }
            }

            string novaFrase = new string(caracteres);

            Console.WriteLine($"Frase com substituição: {novaFrase}");
        }
    }
}
