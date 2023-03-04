using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta
{
    public class Calculadora
    {
        private string resposta;
        private List<string> operadores;
        private string negador;
        private List<Proposicao> proposicoes;


        public List<string> Formula { get; set; }
        public List<string> FormulaAux { get; set; }
        public PegaProposicao pegaProposicoes { get; set; }
        public RemoveParentese removeParentese { get; set; }
        public Calcular calcular { get; set; }

        Form1 form1 = new Form1();
        TabelaVerdade tabelaV = new TabelaVerdade();

        //Construtores

        public Calculadora()
        {
            this.resposta = "";

            defineOperadores();

            this.negador = "~";

            this.proposicoes = new List<Proposicao>();

        }

        public Calculadora(List<string> formula)
        {
            this.Formula = formula;
            this.FormulaAux = formula;
            this.negador = "~";
            this.proposicoes = new List<Proposicao>();

            defineOperadores();
            recolherProposicoes();

            VerificarFBF FBF = new VerificarFBF(Formula, operadores);
            pegaProposicoes = new PegaProposicao(proposicoes);
            calcular = new Calcular(operadores);
            removeParentese = new RemoveParentese(Formula, pegaProposicoes, calcular);

            if (FBF.isFBF())
            {
                tabelaVerdade();
            }
        }

        public Calculadora(List<string> formula, List<bool> valores)
        {
            this.Formula = formula;
            this.FormulaAux = formula;

            defineOperadores();

            this.negador = "~";

            this.proposicoes = new List<Proposicao>();

            VerificarFBF FBF = new VerificarFBF(Formula, operadores);
            pegaProposicoes = new PegaProposicao(proposicoes);
            calcular = new Calcular(operadores);
            removeParentese = new RemoveParentese(Formula, pegaProposicoes, calcular);

            if (FBF.isFBF())
            {
                recolherProposicoes();
                defineProposicoes(valores);
                string FormulaMontada = "";
                foreach (string i in Formula)
                {
                    FormulaMontada = FormulaMontada + "" + i;
                }
                if (isTrue())
                {
                    this.resposta = "A fórmula " + FormulaMontada + " é verdadeira";
                    form1.Resultado(resposta + "\n\nE é uma " + tabelaVerdade());
                }
                else
                {
                    this.resposta = "A fórmula " + FormulaMontada + " é falsa";
                    form1.Resultado(resposta + "\n\nÉ uma " + tabelaVerdade());
                }
            }
            else
            {
                form1.Resultado("A forma não é bem formulada");             
            }

        }
        //Getters
        public string getResposta() { return this.resposta; }

        public List<string> getOperadores() { return this.operadores; }

        public List<Proposicao> getProposicoes() { return proposicoes; }

        //Setters
        public void setResposta(string resposta) { this.resposta = resposta; }

        public void setOperadores(List<string> operadores) { this.operadores = operadores; }

        public void setProposicoes(List<Proposicao> proposicoes) { this.proposicoes = proposicoes; }

        //Métodos
        private void defineOperadores()
        { //Define os operadores

            this.operadores = new List<string>();
            operadores.Add("^");
            operadores.Add("∨");
            operadores.Add("→");
            operadores.Add("↔");

        }

        private void recolherProposicoes()
        {
            List<Char> letras = new List<Char>();

            for (int i = 0; i < this.Formula.Count; i++)
            {
                if (Char.IsLetter(this.Formula[i].ToCharArray()[0]))
                {
                    if (!letras.Contains(this.Formula[i].ToCharArray()[0]))
                    {
                        letras.Add(this.Formula[i].ToCharArray()[0]);
                    }
                }
            }

            foreach (Char i in letras)
            {
                Proposicao p = new Proposicao(i);
                this.proposicoes.Add(p);
            }
        }

        private void defineProposicoes(List<bool> valores)
        {
            for (int i = 0; i < this.proposicoes.Count; i++)
            {
                proposicoes[i].setValor(valores[i]);
            }
        }

        private bool isTrue()
        {
            this.Formula = new List<string>(this.FormulaAux);

            int ii = 0;

            while (ii < Formula.Count)
            {
                if (Formula[ii].Equals("("))
                {
                    this.Formula = removeParentese.executaParenteses();
                    ii = 0;
                }
                else
                {
                    ii++;
                }
            }
            
            List<string> operadores = new List<string>();
            List<Proposicao> proposicoes = new List<Proposicao>();

            for (int i = 0; i < Formula.Count; i++)
            {
                if (this.Formula[i].Equals("~"))
                {
                    Proposicao n;

                    if (Formula[i + 1].Length > 1)
                    {
                        n = new Proposicao(!bool.Parse(Formula[i + 1]));
                    }
                    else
                    {
                        n = new Proposicao(Formula[i + 1].ToCharArray()[0]);
                        n.setValor(!pegaProposicoes.getProposicao(Formula[i + 1].ToCharArray()[0]).getValor());
                    }
                    proposicoes.Add(n);
                    Formula.RemoveAt(i);
                }
                else if (char.IsLetter(Formula[i].ToCharArray()[0]))
                {
                    if (Formula[i].Length > 1)
                    {
                        proposicoes.Add(new Proposicao(Formula[i].ToCharArray()[0], bool.Parse(Formula[i])));
                    }
                    else
                    {
                        proposicoes.Add(pegaProposicoes.getProposicao(Formula[i].ToCharArray()[0]));
                    }
                }
                else
                {
                    operadores.Add(Formula[i]);
                }
            }
            bool resultado;
            try
            {
                resultado = calcular.calcula(proposicoes[0].getValor(), operadores[0].ToCharArray()[0], proposicoes[1].getValor());
            }
            catch (ArgumentOutOfRangeException e)
            {
                resultado = proposicoes[0].getValor();
            }

            for (int i = 1; i < proposicoes.Count - 1; i++)
            {
                try
                {
                    resultado = calcular.calcula(resultado, operadores[i].ToCharArray()[0], proposicoes[i + 1].getValor());
                }
                catch (ArgumentOutOfRangeException e) { }
            }
            return resultado;
        }

        public String tabelaVerdade()
        {

            double tamanho = Math.Pow(2, proposicoes.Count);

            double troca = tamanho / 2;

            bool trocando = false;

            int k = 0;

            List<bool> valores;
            List<List<bool>> listaProp = new List<List<bool>>();

            for (int i = 0; i < proposicoes.Count; i++)
            {
                valores = new List<bool>();

                for (int j = 0; j < tamanho; j++)
                {
                    if (k == troca)
                    {
                        trocando = !trocando;
                        k = 0;
                    }

                    if (!trocando) valores.Add(true);
                    else valores.Add(false);
                    k++;
                }

                k = 0;
                trocando = false;
                listaProp.Add(valores);
                troca = troca / 2;
            }

            List<bool> relacao = new List<bool>();

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < listaProp.Count; j++)
                {
                    this.proposicoes[j].setValor(listaProp[j][i]);
                }
                relacao.Add(isTrue());
            }

            bool hasFalse = false;
            bool hasTrue = false;

            foreach (bool i in relacao)
            {
                if (i) hasTrue = true;
                else hasFalse = true;
            }

            if (hasTrue)
            {
                if (hasFalse)
                {
                    tabelaV.GerarTabela(tamanho + 1, proposicoes.Count + 1, listaProp, relacao, proposicoes);
                    tabelaV.Show();
                    return "Contigência";
                }
                else
                {
                    tabelaV.GerarTabela(tamanho + 1, proposicoes.Count + 1, listaProp, relacao, proposicoes);
                    tabelaV.Show();
                    return "Tautologia";
                }
            }
            tabelaV.GerarTabela(tamanho + 1, proposicoes.Count + 1, listaProp, relacao, proposicoes);
            tabelaV.Show();
            return "Contradição";
        }
    }
}