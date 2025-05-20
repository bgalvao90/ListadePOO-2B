using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    class Produto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }


        public Produto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public Produto()
        {
        }
    }
}
