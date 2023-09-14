using System;
class Program {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine("Digite um número inteiro:");
    num = int.Parse(Console.ReadLine());
    if(num%2==0){
        Console.WriteLine("Seu número é par");
    }else{
        Console.WriteLine("Seu número é ímpar");
    }

  }
}