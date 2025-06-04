using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atividade03.Interface;

namespace Atividade03
{
    class LojaVirtual
    {
        public void RealizarPagamento(IPagamento metodo, decimal valor)
        {
            metodo.ProcessarPagamento(valor);
        }
    }
}
