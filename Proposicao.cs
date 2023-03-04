using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta
{
    public class Proposicao
    {
        private Char nome;
        private bool valor;

        public Proposicao()
        {
            this.nome = '0';
            this.valor = false;
        }

        public Proposicao(bool valor)
        {
            this.nome = '0';
            this.valor = valor;
        }

        public Proposicao(Char nome, bool valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public Proposicao(Char nome)
        {
            this.nome = nome;
            this.valor = false;
        }

        public Char getNome()
        {
            return nome;
        }

        public bool getValor()
        {
            return valor;
        }

        public void setNome(Char nome)
        {
            this.nome = nome;
        }

        public void setValor(bool valor)
        {
            this.valor = valor;
        }
    }
}