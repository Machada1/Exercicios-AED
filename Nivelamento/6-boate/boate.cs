using System;
class Program {
  public static void Main (string[] args) {
      int idade;
      Console.WriteLine ($"Digite sua idade");
      idade = int.Parse(Console.ReadLine());
      if(idade <18){
          Console.WriteLine("Sem Permissão");
      }else{
          Console.WriteLine("Permissão concedida");
      }

  }
}