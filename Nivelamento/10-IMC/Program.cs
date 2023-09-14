using System;
using System.Collections.Generic;
using System.IO;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Calculador de IMC!");

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Cadastrar novo cálculo de IMC");
                Console.WriteLine("2 - Consultar cálculos de IMC existentes");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarIMC();
                        break;
                    case 2:
                        ConsultarIMCs();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Escolha novamente.");
                        break;
                }
            }
        }

        static void CadastrarIMC()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em cm): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = (peso/((altura*altura)/10000));

            string arquivoPath = "calculos_imc.txt";

            using (StreamWriter writer = File.AppendText(arquivoPath))
            {
                writer.WriteLine($"Nome: {nome}, Idade: {idade}, Peso: {peso} kg, Altura: {altura} cm, IMC: {imc}");
            }

            Console.WriteLine("Cálculo de IMC registrado com sucesso!");
        }

        static void ConsultarIMCs()
        {
            string arquivoPath = "calculos_imc.txt";

            if (File.Exists(arquivoPath))
            {
                Console.WriteLine("Cálculos de IMC registrados:");
                List<string> registros = new List<string>(File.ReadAllLines(arquivoPath));
                foreach (string registro in registros)
                {
                    Console.WriteLine(registro);
                }
            }
            else
            {
                Console.WriteLine("Nenhum cálculo de IMC registrado ainda.");
            }
        }
    }
}
