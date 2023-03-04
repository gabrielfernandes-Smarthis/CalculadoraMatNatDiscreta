using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta
{
    public class PegaProposicao
    {
        public List<Proposicao> Proposicoes { get; set; }
        public PegaProposicao(List<Proposicao> proposicoes)
        {
            this.Proposicoes = proposicoes;
        }

        public Proposicao getProposicao(Char nome)
        {
            foreach (Proposicao i in this.Proposicoes)
            {
                if (i.getNome().Equals(nome)) return i;
            }
            return null;
        }
    }
}
