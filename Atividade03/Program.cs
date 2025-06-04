using Atividade03;
using Atividade03.Interface;
using Atividade03.Pagamentos;

Console.WriteLine("Bem vindo a loja virtual:");

Console.WriteLine("Selecione o método de pagamento:");

Console.WriteLine("1 - Cartão de Crédito");
Console.WriteLine("2 - Boleto Bancário");
Console.WriteLine("3 - Pix");

string opcao = Console.ReadLine();

decimal valorPagamento;

Console.WriteLine("Digite o valor do pagamento:");
valorPagamento = decimal.Parse(Console.ReadLine());
LojaVirtual lojaVirtual = new LojaVirtual();

switch (opcao)
{
    case "1":
        IPagamento pagamentoCartao = new PagamentoCartaoCredito();
        lojaVirtual.RealizarPagamento(pagamentoCartao, valorPagamento);
        break;
    case "2":
        IPagamento pagamentoBoleto = new PagamentoBoleto();
        lojaVirtual.RealizarPagamento(pagamentoBoleto, valorPagamento);
        break;
    case "3":
        IPagamento pagamentoPix = new PagamentoPix();
        lojaVirtual.RealizarPagamento(pagamentoPix, valorPagamento);
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}