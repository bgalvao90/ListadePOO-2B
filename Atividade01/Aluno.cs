using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno() { }

        public Aluno(string ra, string nome, int idade)
        {
            RA = ra;
            Nome = nome;
            Idade = idade;
        }
    }
}
