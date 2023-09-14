using System;
class Program
{
    static void Main(string[] args)
    {
        int [] v = new int [5] {5,5,3,2,5}; 
        double soma = somaVet(v, 0);
        Console.WriteLine($"O valor da soma do vetor é: {soma}");
    }

    static int somaVet(int [] v, int pos)
    {
        if (pos ==v.Length){
            return 0;
        }
        return(somaVet(v, pos+1)+v[pos]);
    }
}