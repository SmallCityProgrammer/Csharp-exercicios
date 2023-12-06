using System;

namespace Empresa
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] votos = new int[6];
      string[] sistemas = { "Windows Server", "Unix", "Linux", "Netware", "Mac OS", "Outro" };
      int totalVotos = 0;

      Console.WriteLine("Qual o melhor Sistema Operacional para uso em servidores?");
      Console.WriteLine("As opções são:");
      for (int i = 0; i < sistemas.Length; i++)
      {
        Console.WriteLine($"{i + 1}- {sistemas[i]}");
      }
      Console.WriteLine("Digite 0 para encerrar a votação.");

      while (true)
      {
        Console.Write("Voto: ");
        string entrada = Console.ReadLine();
        int voto;

        if (int.TryParse(entrada, out voto))
        {
          if (voto >= 1 && voto <= 6)
          {
            votos[voto - 1]++;
            totalVotos++;
          }
          else if (voto == 0)
          {
            break;
          }
          else
          {
            Console.WriteLine("Opção inválida. Por favor, digite um número de 1 a 6 ou 0 para encerrar.");
          }
        }
        else
        {
          Console.WriteLine("Entrada inválida. Por favor, digite um número de 1 a 6 ou 0 para encerrar.");
        }
      }

      Console.WriteLine("Sistema Operacional   Votos   %");
      Console.WriteLine("------------------- ----- ---");

      for (int i = 0; i < sistemas.Length; i++)
      {
        double percentual = (double)votos[i] / totalVotos * 100;
        Console.WriteLine($"{sistemas[i],-20} {votos[i],-7} {percentual:F0}%");
      }

      Console.WriteLine("------------------- ----- ---");
      Console.WriteLine($"Total {totalVotos}");

      int maxVotos = 0;
      int maiorIndice = 0;

      for (int i = 0; i < sistemas.Length; i++)
      {
        if (votos[i] > maxVotos)
        {
          maxVotos = votos[i];
          maiorIndice = i;
        }
      }

      Console.WriteLine($"O Sistema Operacional mais votado foi o {sistemas[maiorIndice]}, com {votos[maiorIndice]} votos, correspondendo a {(double)maxVotos / totalVotos * 100:F0}% dos votos.");
    }
  }
}
