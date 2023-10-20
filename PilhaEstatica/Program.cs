using System;

public class PilhaEstatica<T>
{
    private T[] pilha;
    private int topo;
    private int capacidade;

    public PilhaEstatica(int capacidade)
    {
        this.capacidade = capacidade;
        pilha = new T[capacidade];
        topo = -1;
    }

    public void CriarPilha()
    {
        topo = -1;
    }

    public void InserirElemento(T item)
    {
        if (EstaCheia())
        {
            Console.WriteLine("A pilha está cheia. Não é possível inserir elementos.");
            return;
        }

        topo++;
        pilha[topo] = item;
    }

    public T RemoverElemento()
    {
        if (EstaVazia())
        {
            Console.WriteLine("A pilha está vazia. Não é possível remover elementos.");
            return default(T);
        }

        T item = pilha[topo];
        topo--;
        return item;
    }

    public bool EstaVazia()
    {
        return topo == -1;
    }

    public T LerElemento()
    {
        if (EstaVazia())
        {
            Console.WriteLine("A pilha está vazia. Não é possível ler o elemento do topo.");
            return default(T);
        }

        return pilha[topo];
    }

    public bool EstaCheia()
    {
        return topo == capacidade - 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PilhaEstatica<int> pilha = new PilhaEstatica<int>(5);

        pilha.InserirElemento(1);
        pilha.InserirElemento(2);
        pilha.InserirElemento(3);
        pilha.InserirElemento(4);
        pilha.InserirElemento(5);

        Console.WriteLine("A pilha está vazia? " + pilha.EstaVazia());
        Console.WriteLine("A pilha está cheia? " + pilha.EstaCheia());

        Console.WriteLine("Elemento no topo da pilha: " + pilha.LerElemento());

        pilha.RemoverElemento();
        Console.WriteLine("Elemento removido do topo da pilha.");
        Console.WriteLine("Elemento no topo da pilha: " + pilha.LerElemento());
        pilha.RemoverElemento();
        pilha.RemoverElemento();
        pilha.RemoverElemento();
        pilha.RemoverElemento();


        Console.WriteLine("A pilha está vazia? " + pilha.EstaVazia());
        Console.WriteLine("A pilha está cheia? " + pilha.EstaCheia());
    }
}
