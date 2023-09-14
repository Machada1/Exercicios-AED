using System;
class Program {
  public static void Main (string[] args) {
      double salario;
      Console.WriteLine ($"Digite o seu salário");
      salario = double.Parse(Console.ReadLine());
      if(salario < 1700){
          salario += 300;
          Console.WriteLine($"Salário com reajuste: R${salario}");
      }else{
          salario += 200;
          Console.WriteLine($"Salário com reajuste: R${salario}");
      }

  }
}