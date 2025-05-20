using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Atividade02;

List<Produto> lista = new List<Produto>();

void MostrarMenu()
{
    Console.WriteLine("Digite qual funcionalidade você quer utilizar:");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Remover produto");
    Console.WriteLine("3 - Pesquisar produto");
    Console.WriteLine("4 - Mostrar produto com menor valor");
    Console.WriteLine("5 - Sair");
}

int opcao;
do
{
    MostrarMenu();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.Write("Digite a descrição: ");
            string descricaoProduto = Console.ReadLine();
            Console.Write("Digite o valor: ");
            decimal valorProduto = decimal.Parse(Console.ReadLine());

                Produto produtoAdicionar = new Produto(descricaoProduto, valorProduto);
                lista.Add(produtoAdicionar);
                Console.WriteLine($"Produto Descrição: {descricaoProduto}, Valor: ${valorProduto.ToString("F2", CultureInfo.InvariantCulture)} cadastrado com sucesso!");
           
            break;

       

        case 2:
            Console.Clear();
            Console.Write("Digite a descrição do produto que você deseja remover: ");
            string descricaoRemover = Console.ReadLine();

            if (!string.IsNullOrEmpty(descricaoRemover))
            {
                var produtoParaRemover = lista.Find(x => x.Descricao.Trim().ToLower() == descricaoRemover.Trim().ToLower());
                if (produtoParaRemover != null)
                {
                    lista.Remove(produtoParaRemover);
                    Console.WriteLine($"Produto com descrição '{descricaoRemover}' removido com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Produto com descrição '{descricaoRemover}' não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("A descrição do produto não pode ser vazia.");
            }
            Console.WriteLine();
            break;

        case 3:
            Console.Clear();
            Console.Write("Digite a descrição do produto que deseja localizar: ");
            string descricaoPesquisar = Console.ReadLine().ToLower();

            var produtoEncontrado = lista.Find(x => x.Descricao.Trim().ToLower() == descricaoPesquisar.Trim().ToLower().ToLower());
            if (produtoEncontrado != null)
            {
                Console.WriteLine($"Produto encontrado: Descrição: {produtoEncontrado.Descricao}, Valor: ${produtoEncontrado.Valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Produto com descrição '{descricaoPesquisar}' não encontrado.");
            }
            Console.WriteLine();
            break;
        case 4:
            Console.Clear();
            var produtoMenorValor = lista.OrderBy(x => x.Valor).FirstOrDefault();
            if (produtoMenorValor != null)
            {
                Console.WriteLine($"Produto com menor valor: Descrição: {produtoMenorValor.Descricao}, Valor: ${produtoMenorValor.Valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            Console.WriteLine();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Encerrando o programa.");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 5);
