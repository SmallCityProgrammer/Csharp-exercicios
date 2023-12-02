using System;

namespace Program
{
  class Exercicio
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite o Salário atual: ");
      int salario = Convert.ToInt32(Console.ReadLine());
      (int aumento, double percentual) = Reajuste.Aumento(salario);

      Console.WriteLine($"Salário antes do ajuste:  {salario}");
      Console.WriteLine($"Percentual de aumento: {percentual}%");
      Console.WriteLine($"Aumento: {aumento}");
      Console.WriteLine($"Salário com reajuste: {salario + aumento}");
    }
    class Reajuste
    {
      public static (int, double) Aumento(int salarioAtual)
      {
        int aumento = 0;
        double porcentagem = 0;

        if (salarioAtual <= 280)
        {
          porcentagem = 20;
          aumento = (int)(salarioAtual * 0.2);
        }
        else if (salarioAtual > 280 && salarioAtual <= 700)
        {
          porcentagem = 15;
          aumento = (int)(salarioAtual * 0.15);
        }
        else if (salarioAtual > 700 && salarioAtual <= 1500)
        {
          porcentagem = 10;
          aumento = (int)(salarioAtual * 0.1);
        }
        else
        {
          porcentagem = 5;
          aumento = (int)(salarioAtual * 0.05);
        }

        return (aumento, porcentagem);
      }
    }
  }


}
