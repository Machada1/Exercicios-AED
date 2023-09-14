using System;
class Program {
  public static void Main (string[] args) {
    int [] media = new int[5];
    for(int i=0;i<5;i++){
      Console.WriteLine ($"Digite a nota do aluno {i+1}:");
      media[i]= int.Parse(Console.ReadLine());
    }

    double Media = 0;
    for(int i=0;i<5; i++){
        Media += media[i];
    } 

    Console.WriteLine($"A media da nota dos alunos é: {Media/5}");
    
  }
}