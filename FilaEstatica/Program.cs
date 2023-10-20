using System;

public class FilaEstatica<T>
{
    private T[] fila;
    private int frente;
    private int tras;
    private int capacidadeMaxima;

    public FilaEstatica(int capacidade)
    {
        capacidadeMaxima = capacidade;
        fila = new T[capacidade];
        frente = tras = -1;
    }

    public void Enfileirar(T item)
    {
        if (EstaCheia())
        {
            Console.WriteLine("A fila está cheia. Não é possível enfileirar elementos.");
            return;
        }

        if (frente == -1)
        {
            frente = tras = 0;
        }
        else
        {
            tras = (tras + 1) % capacidadeMaxima;
        }

        fila[tras] = item;
    }

    public T Desenfileirar()
    {
        if (EstaVazia())
        {
            Console.WriteLine("A fila está vazia. Não é possível desenfileirar elementos.");
            return default(T);
        }

        T item = fila[frente];

        if (frente == tras)
        {
            frente = tras = -1;
        }
        else
        {
            frente = (frente + 1) % capacidadeMaxima;
        }

        return item;
    }

    public bool EstaVazia()
    {
        return frente == -1;
    }

    public bool EstaCheia()
    {
        return (tras + 1) % capacidadeMaxima == frente;
    }

    public T LerElemento()
    {
        if (EstaVazia())
        {
            Console.WriteLine("A fila está vazia. Não é possível ler o elemento.");
            return default(T);
        }

        return fila[frente];
    }
}

class Program
{
    static void Main(string[] args)
    {
        FilaEstatica<int> fila = new FilaEstatica<int>(5);

        fila.Enfileirar(1);
        fila.Enfileirar(2);
        fila.Enfileirar(3);
        fila.Enfileirar(4);
        fila.Enfileirar(5);

        Console.WriteLine("A fila está vazia? " + fila.EstaVazia());
        Console.WriteLine("A fila está cheia? " + fila.EstaCheia());

        Console.WriteLine("Elemento na frente da fila: " + fila.LerElemento());

        fila.Desenfileirar();
        Console.WriteLine("Elemento desenfileirado da frente da fila.");

        Console.WriteLine("Elemento na frente da fila após desenfileirar: " + fila.LerElemento());

        fila.Desenfileirar();
        Console.WriteLine("Elemento desenfileirado da frente da fila.");
        Console.WriteLine("Elemento na frente da fila após desenfileirar: " + fila.LerElemento());

        fila.Desenfileirar();
        Console.WriteLine("Elemento desenfileirado da frente da fila.");
        Console.WriteLine("Elemento na frente da fila após desenfileirar: " + fila.LerElemento());

        fila.Desenfileirar();
        fila.Desenfileirar();

        Console.WriteLine("A fila está vazia? " + fila.EstaVazia());
        Console.WriteLine("A fila está cheia? " + fila.EstaCheia());
    }
}
