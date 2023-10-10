using System;

public class Pagamento
{
    // Método para pagamento com cartão de crédito
    public void PagarComCartaoCredito(string nomeDoCliente)//,double valorTotal, string numeroCartao, string nomeTitular, string dataValidade, string codigoSeguranca)
    {
        Console.WriteLine();
        // Lógica de processamento do pagamento com cartão de crédito
        Console.WriteLine("Processando pagamento com cartão de crédito...");
        Console.WriteLine($"Cliente: {nomeDoCliente}.");
        //Console.WriteLine($"O numero do(a) Cliente é {numeroDoCliente}.");
        //Console.WriteLine($"Número do Cartão: {numeroCartao}");
        //Console.WriteLine($"Nome do Titular: {nomeTitular}");
        //Console.WriteLine($"Data de Validade: {dataValidade}");
        //Console.WriteLine($"Código de Segurança: {codigoSeguranca}");
        Console.WriteLine("Pagamento com cartão de crédito concluído!");
        return;
    }

    // Método para pagamento em dinheiro
    public void PagarEmDinheiro(double valorTotal)
    {
        // Lógica de processamento do pagamento em dinheiro
        Console.WriteLine("Recebendo pagamento em dinheiro...");
        Console.WriteLine($"Valor Total: R$ {valorTotal}");
        Console.WriteLine("Pagamento em dinheiro recebido!");
    }

    // Método para pagamento com cartão de alimentação
    public void PagarComCartaoAlimentacao(double valorTotal, string numeroCartao)
    {
        // Lógica de processamento do pagamento com cartão de alimentação
        Console.WriteLine("Processando pagamento com cartão de alimentação...");
        Console.WriteLine($"Valor Total: R$ {valorTotal}");
        Console.WriteLine($"Número do Cartão de Alimentação: {numeroCartao}");
        Console.WriteLine("Pagamento com cartão de alimentação concluído!");
    }
}

//class Program
//{
  //  static void Main()
    //{
      //  Pagamento pagamento = new Pagamento();

        //// Exemplo de pagamento com cartão de crédito
        //pagamento.PagarComCartaoCredito(100.00, "1234 5678 9012 3456", "João da Silva", "12/25", "123");

        //// Exemplo de pagamento em dinheiro
        //pagamento.PagarEmDinheiro(50.00);

        //// Exemplo de pagamento com cartão de alimentação
        //pagamento.PagarComCartaoAlimentacao(75.00, "9876 5432 1098 7654");
    //}
//}
