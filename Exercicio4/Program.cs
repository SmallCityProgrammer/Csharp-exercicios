using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      NotaFiscal notaFiscal = Pagamento();
      Console.WriteLine("\nCupom Fiscal");
      Console.WriteLine("Tipo de carne: " + Enum.GetName(typeof(TipoCarne), notaFiscal.TipoCarne));
      Console.WriteLine("Quantidade: " + notaFiscal.Quantidade + " Kg");
      Console.WriteLine("Tipo de pagamento: " + Enum.GetName(typeof(TipoPagamento), notaFiscal.TipoPagamento));
      Console.WriteLine("Preço total: R$ " + notaFiscal.ValorTotal.ToString("0.00"));

      if (notaFiscal.TipoPagamento == (int)TipoPagamento.Cartao)
      {
        double desconto = notaFiscal.ValorTotal * 0.05;
        double valorFinal = notaFiscal.ValorTotal - desconto;
        Console.WriteLine("Desconto (5%): R$ " + desconto.ToString("0.00"));
        Console.WriteLine("Valor a pagar: R$ " + valorFinal.ToString("0.00"));
      }
      else
      {
        Console.WriteLine("Sem desconto");
        Console.WriteLine("Valor a pagar: R$ " + notaFiscal.ValorTotal.ToString("0.00"));
      }
    }

    static NotaFiscal Pagamento()
    {
      Console.WriteLine("Escolha um tipo de carne: ");
      Console.WriteLine("1-File Duplo\n2-Alcatra\n3-Picanha");
      string carne = Console.ReadLine();

      int tipoCarne = 0;
      int quantidade = 0;

      switch (carne)
      {
        case "1":
        case "2":
        case "3":
          tipoCarne = int.Parse(carne);
          Console.WriteLine("Agora escolha a quantidade: ");
          quantidade = int.Parse(Console.ReadLine());
          break;
        default:
          Console.WriteLine("Essa opção não existe, tente novamente.");
          return Pagamento();
      }

      Console.WriteLine("Escolha a forma de Pagamento: \n1-Cartão Tabajara\n2-Dinheiro");
      string formaPagamento = Console.ReadLine();
      if (formaPagamento != "1" && formaPagamento != "2")
      {
        Console.WriteLine("Forma de pagamento não aceita!");
        return Pagamento();
      }

      NotaFiscal nota = new NotaFiscal
      {
        TipoPagamento = int.Parse(formaPagamento),
        TipoCarne = tipoCarne,
        Quantidade = quantidade,
        ValorTotal = CalcularPrecoTotal(tipoCarne, quantidade)
      };

      Console.WriteLine("Finalizando Compra!");
      return nota;
    }

    static double CalcularPrecoTotal(int tipoCarne, int quantidade)
    {
      double preco = 0;
      double precoKg = 0;

      switch (tipoCarne)
      {
        case (int)TipoCarne.FileDuplo:
          precoKg = quantidade <= 5 ? 4.9 : 5.8;
          break;
        case (int)TipoCarne.Alcatra:
          precoKg = quantidade <= 5 ? 5.9 : 6.8;
          break;
        case (int)TipoCarne.Picanha:
          precoKg = quantidade <= 5 ? 6.9 : 7.8;
          break;
      }

      preco = precoKg * quantidade;
      return preco;
    }

    public enum TipoCarne
    {
      FileDuplo = 1,
      Alcatra = 2,
      Picanha = 3
    }

    public enum TipoPagamento
    {
      Cartao = 1,
      Dinheiro = 2
    }
  }
}
