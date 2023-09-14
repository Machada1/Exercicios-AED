using System;
class Program {
  public static void Main (string[] args) {
    double [] altura = new double[10];
    int [] matricula = new int [10];
    double maior,menor;
    int posM=0;
    int posm=0;
    
    for(int i=0;i<10;i++){
        Console.WriteLine($"Digite a altura do aluno {i+1}");
        altura[i] = double.Parse(Console.ReadLine());
        Console.WriteLine($"Digite a matrícula do aluno {i+1}");
        matricula[i]= int.Parse(Console.ReadLine());
    }

    maior=menor=altura[0];

    for(int i=1;i<10;i++){
        if(altura[i]>maior){
            maior = altura[i];
            posM=i;
        }if(altura[i]<menor){
            menor = altura[i];
            posm=i;
        }
    }

    Console.WriteLine($"A matricula do maior aluno é {matricula[posM]}");
    Console.WriteLine($"A matricula do menor aluno é {matricula[posm]}");

  }
}