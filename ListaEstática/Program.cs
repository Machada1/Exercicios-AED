using System;
using System.Collections.Generic;

public class ListaEstatica<T>
{
    private T[] lista;
    private int tamanho;
    private int capacidade;

    public ListaEstatica(int capacidade)
    {
        this.capacidade = capacidade;
        lista = new T[capacidade];
        tamanho = 0;
    }

    public void Inserir(T item)
    {
        if (tamanho < capacidade)
        {
            lista[tamanho] = item;
            tamanho++;
        }
        else
        {
            Console.WriteLine("A lista está cheia. Não é possível inserir elementos.");
        }
    }

    public void Remover(T item)
    {
        for (int i = 0; i < tamanho; i++)
        {
            if (EqualityComparer<T>.Default.Equals(lista[i], item))
            {
                for (int j = i; j < tamanho - 1; j++)
                {
                    lista[j] = lista[j + 1];
                }
                tamanho--;
                return;
            }
        }
    }

    public void RemoverNaPosicao(int indice)
    {
        if (indice >= 0 && indice < tamanho)
        {
            for (int i = indice; i < tamanho - 1; i++)
            {
                lista[i] = lista[i + 1];
            }
            tamanho--;
        }
        else
        {
            Console.WriteLine("Índice inválido. Não é possível remover o elemento.");
        }
    }

    public bool EstaVazia()
    {
        return tamanho == 0;
    }

    public T LerElementoNaPosicao(int indice)
    {
        if (indice >= 0 && indice < tamanho)
        {
            return lista[indice];
        }
        else
        {
            Console.WriteLine("Índice inválido. Não é possível ler o elemento.");
            return default(T);
        }
    }

    public void Concatenar(ListaEstatica<T> outraLista)
    {
        if (tamanho + outraLista.tamanho <= capacidade)
        {
            for (int i = 0; i < outraLista.tamanho; i++)
            {
                Inserir(outraLista.LerElementoNaPosicao(i));
            }
        }
        else
        {
            Console.WriteLine("A capacidade não é suficiente para concatenar as listas.");
        }
    }

    public void Percorrer()
    {
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write(lista[i] + " ");
        }
        Console.WriteLine();
    }

    public int Localizar(T item)
    {
        for (int i = 0; i < tamanho; i++)
        {
            if (EqualityComparer<T>.Default.Equals(lista[i], item))
            {
                return i;
            }
        }
        return -1; // Retorna -1 se o elemento não for encontrado.
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEstatica<int> minhaLista = new ListaEstatica<int>(10);

        minhaLista.Inserir(1);
        minhaLista.Inserir(2);
        minhaLista.Inserir(3);

        Console.WriteLine("Elemento na posição 1: " + minhaLista.LerElementoNaPosicao(1));

        minhaLista.Percorrer();

        minhaLista.Remover(2);
        Console.WriteLine("Removido o elemento 2.");

        minhaLista.Percorrer();

        Console.WriteLine("A lista está vazia? " + minhaLista.EstaVazia());

        ListaEstatica<int> outraLista = new ListaEstatica<int>(5);
        outraLista.Inserir(4);
        outraLista.Inserir(5);

        Console.WriteLine("Outra lista:");
        outraLista.Percorrer();

        minhaLista.Concatenar(outraLista);
        Console.WriteLine("Lista concatenada:");

        minhaLista.Percorrer();

        int indice = minhaLista.Localizar(4);
        if (indice != -1)
        {
            Console.WriteLine("O elemento 4 está na posição " + indice);
        }
        else
        {
            Console.WriteLine("O elemento 4 não foi encontrado na lista.");
        }
    }
}
