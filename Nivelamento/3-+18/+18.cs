using System;
class Program {
  public static void Main (string[] args) {
    int [] idades = new int[10];
    for(int i=0;i<10;i++){
      Console.WriteLine ($"Digite a idade da pessoa {i+1}:");
      idades[i]= int.Parse(Console.ReadLine());
    }
    double maior = 0;
    for(int i=0;i<10; i++){
        if(idades[i] >= 18){
            maior++;
        }
    } 

    Console.WriteLine($"A quantidade de pessoas maiores de idade são {maior}");
    
  }
}