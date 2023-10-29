using System;

public class FilaEstatica
{
    private int[] fila;
    private int tamanho;
    private int capacidade;
    private int inicio;
    private int fim;

    public FilaEstatica(int capacidade)
    {
        this.capacidade = capacidade;
        this.fila = new int[capacidade];
        this.tamanho = 0;
        this.inicio = 0;
        this.fim = -1;
    }

    public void Inserir(int elemento)
    {
        if (tamanho == capacidade)
        {
            Console.WriteLine("Fila cheia.");
            return;
        }

        fim = (fim + 1) % capacidade;
        fila[fim] = elemento;
        tamanho++;
    }

    public int Remover()
    {
        if (EstaVazia())
        {
            throw new InvalidOperationException("Fila vazia.");
        }

        int elementoRemovido = fila[inicio];
        inicio = (inicio + 1) % capacidade;
        tamanho--;
        return elementoRemovido;
    }

    public bool EstaVazia()
    {
        return tamanho == 0;
    }

    public int LerElemento()
    {
        if (EstaVazia())
        {
            throw new InvalidOperationException("Fila vazia.");
        }

        return fila[inicio];
    }
}

class Program
{
    static void Main(string[] args)
    {
        FilaEstatica fila = new FilaEstatica(5);

        fila.Inserir(1);
        fila.Inserir(2);
        fila.Inserir(3);

        Console.WriteLine("Elemento lido: " + fila.LerElemento());

        fila.Remover();
        Console.WriteLine("Elemento removido.");

        Console.WriteLine("Fila vazia: " + fila.EstaVazia());

        fila.Inserir(4);
        fila.Inserir(5);
        fila.Inserir(6);

        while (!fila.EstaVazia())
        {
            Console.WriteLine("Elemento removido: " + fila.Remover());
        }
    }
}
