using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade03.Interface;

namespace Atividade03.Pagamentos
{
    class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentNullException("O valor do pagamento deve ser maior que zero.");
            }

            Console.WriteLine($"Pagamento de {valor.ToString("C2")} processado no cartão de crédito.");
        }
    }
}
