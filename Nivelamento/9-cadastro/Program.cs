using System;
using System.IO;

namespace GravarLerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o e-mail: ");
            string email = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o RG: ");
            string rg = Console.ReadLine();

            string arquivoPath = "informacoes.txt";

            // Gravar as informações no arquivo
            using (StreamWriter writer = new StreamWriter(arquivoPath))
            {
                writer.WriteLine($"Nome: {nome}");
                writer.WriteLine($"E-mail: {email}");
                writer.WriteLine($"Telefone: {telefone}");
                writer.WriteLine($"RG: {rg}");
            }

            Console.WriteLine("Informações gravadas no arquivo.");

            // Ler e exibir as informações do arquivo
            Console.WriteLine("Lendo informações do arquivo:");
            using (StreamReader reader = new StreamReader(arquivoPath))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
