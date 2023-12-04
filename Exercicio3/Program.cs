using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    List<double> salarios = new List<double>();

    Console.WriteLine("Digite os salários dos vendedores (digite 'fim' para encerrar):");

    while (true)
    {
      string input = Console.ReadLine();

      if (input.ToLower() == "fim")
      {
        break;
      }

      if (double.TryParse(input, out double salario))
      {
        salarios.Add(salario);
      }
      else
      {
        Console.WriteLine("Valor inválido. Por favor, digite um número válido ou 'fim' para encerrar.");
      }
    }

    int[] contadores = new int[10];


    foreach (double salario in salarios)
    {
      if (salario < 1000)
      {
        int indice = (int)Math.Floor((salario - 200) / 100);

        if (indice >= 0 && indice < contadores.Length)
        {
          contadores[indice]++;
        }
      }
      else
      {
        contadores[9]++;
      }
    }

    Console.WriteLine("Quantidade de vendedores por faixa salarial:");

    double faixaInicial = 200;
    for (int i = 0; i < contadores.Length; i++)
    {
      double faixaFinal = (i < contadores.Length - 1) ? faixaInicial + 99 : 1000;
      Console.WriteLine($"${faixaInicial} - ${faixaFinal}: {contadores[i]} vendedores");
      faixaInicial = faixaFinal + 1;
    }
  }
}
