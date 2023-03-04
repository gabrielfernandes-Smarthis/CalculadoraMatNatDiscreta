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

        public Calculadora(List<string> formula, List<bool> valores)
        {
            this.Formula = formula;
            this.FormulaAux = formula;

            defineOperadores();

            this.negador = "~";

            this.proposicoes = new List<Proposicao>();

            if (isFBF())
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
                throw new ArgumentException("A forma não é bem formulada");
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

        //Checa se a fórmula é bem formulada(FBF) ou não
        private bool isFBF()
        {
            try
            {
                for (int i = 0; i < Formula.Count; i++)
                {
                    if (char.IsDigit(Formula[i].ToCharArray()[0]))
                    {
                        throw new ArgumentException();
                    }
                }
            }
            catch (ArgumentException e) { return false; }

            int cnt = 0; //Contador de parenteses

            //Tratamento de excessão para as futuras checagens que podem acatar em IndexOutOfBounds
            for (int i = 0; i < this.Formula.Count; i++)
            {
                //Caso a diferença de parênteses seja negativa é evidente que a fórmula não é uma FBF
                if (cnt < 0) return false;
                if (cnt >= 0)
                {
                    if (this.operadores.Contains(this.Formula[i]))
                    {
                        try
                        {
                            //Caso haja 2 operadores em sequência é evidente que a fórmula não é uma FBF
                            if (this.operadores.Contains(this.Formula[i + 1])) return false;
                        }
                        //Tratamento de excessão IndexOutOfBounds, caso entre é evidente que não é uma FBF
                        catch (ArgumentOutOfRangeException e)
                        {
                            return false;
                        }

                    }
                    if (Char.IsLetter(this.Formula[i].ToCharArray()[0]))
                    {
                        try
                        {
                            /*Caso haja 2 proposições em sequência
                              sem nenhum operador entre ela é
                              evidente que a fórmula não é uma FBF*/
                            if (Char.IsLetter(this.Formula[i + 1].ToCharArray()[0]) || this.Formula[i + 1].Equals(this.negador))
                            {
                                return false;
                            }

                        }
                        //Tratamento de excessão IndexOutOfBounds, caso entre é evidente que é uma FBF
                        catch (ArgumentOutOfRangeException e)
                        {
                            return true;
                        }
                    }
                    if (this.Formula[i].Equals(this.negador))
                    {

                        try
                        {
                            //Caso haja uma não proposição seguida de uma negação é evidente que a fórmula não é uma FBF
                            if (!Char.IsLetter(this.Formula[i + 1].ToCharArray()[0]) && !Formula[i + 1].Equals("(")) return false;
                        }
                        //Tratamento de excessão IndexOutOfBounds, caso entre é evidente que é uma FBF
                        catch (ArgumentOutOfRangeException e)
                        {
                            return false;
                        }
                    }
                    //Caso um parêntese seja aberto é somado 1 ao contador de parênteses
                    if (this.Formula[i].Equals("("))
                    {
                        cnt++;
                        try
                        {
                            if (!Char.IsLetter(this.Formula[i + 1].ToCharArray()[0]) && !Formula[i + 1].Equals("("))
                            {
                                if (!this.Formula[i + 1].Equals(this.negador)) return false;
                            }

                        }
                        //Tratamento de excessão IndexOutOfBounds, caso entre é evidente que não é uma FBF
                        catch (ArgumentOutOfRangeException e)
                        {
                            return false;
                        }

                    }
                    //Caso um parêntese seja fechado é subtraido 1 ao contador de parêntes
                    if (this.Formula[i].Equals(")"))
                    {
                        cnt--;
                        try
                        {
                            if (!Char.IsLetter(this.Formula[i - 1].ToCharArray()[0]) && !Formula[i - 1].Equals(")")) return false;
                        }
                        //Tratamento de excessão IndexOutOfBounds, caso entre é evidente que não é uma FBF
                        catch (ArgumentOutOfRangeException e) { }
                    }
                }
            }
            /*Caso não haja nenhum erro nas checagens anteriores e a diferença de parêntes 
             * seja igual a 0  é evidente que a fórmula é uma FBF*/
            if (cnt == 0) return true;

            //Caso o contrário é evidente que a fórmula não é uma FBF
            return false;
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
                    executaParenteses();
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
                        n.setValor(!getProposicao(Formula[i + 1].ToCharArray()[0]).getValor());
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
                        proposicoes.Add(getProposicao(Formula[i].ToCharArray()[0]));
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
                resultado = calcula(proposicoes[0].getValor(), operadores[0].ToCharArray()[0], proposicoes[1].getValor());
            }
            catch (ArgumentOutOfRangeException e)
            {
                resultado = proposicoes[0].getValor();
            }

            for (int i = 1; i < proposicoes.Count - 1; i++)
            {
                try
                {
                    resultado = calcula(resultado, operadores[i].ToCharArray()[0], proposicoes[i + 1].getValor());
                }
                catch (ArgumentOutOfRangeException e) { }
            }
            return resultado;
        }

        public void executaParenteses()
        {
            int comecoParentese = 0;
            int finalParentese = 0;

            List<string> parentese = new List<string>();
            List<Proposicao> propParentese = new List<Proposicao>();
            List<string> opParentese = new List<string>();

            int size = Formula.Count;

            try
            {
                for (int i = 0; i < size; i++)
                {
                    if (Formula[i].Equals("(")) comecoParentese = i;
                }

                finalParentese = comecoParentese;

                while (!this.Formula[finalParentese].Equals(")")) { finalParentese++; }

                for (int i = comecoParentese; i < finalParentese - 1; i++)
                {
                    parentese.Add(this.Formula[i + 1]);
                }

                int controleNegacao = 0;

                for (int i = 0; i < parentese.Count; i++)
                {
                    controleNegacao = i;

                    if (parentese[i].Equals("~"))
                    {
                        Proposicao n;
                        if (parentese[i + 1].Length > 1)
                        {
                            n = new Proposicao(parentese[i + 1].ToCharArray()[0]);
                        }
                        else
                        {
                            n = new Proposicao(parentese[i + 1].ToCharArray()[0]);
                            n.setValor(!getProposicao(parentese[i + 1].ToCharArray()[0]).getValor());
                        }

                        propParentese.Add(n);
                        parentese.RemoveAt(i);
                    }
                    else if (Char.IsLetter(parentese[i].ToCharArray()[0]))
                    {
                        if (parentese[i].Length > 1)
                        {
                            propParentese.Add(new Proposicao(parentese[i].ToCharArray()[0], bool.Parse(parentese[i])));
                        }
                        else
                        {
                            propParentese.Add(getProposicao(parentese[i].ToCharArray()[0]));
                        }
                    }
                    else
                    {
                        opParentese.Add(parentese[i]);
                    }
                }
                for (int i = comecoParentese; i <= finalParentese; i++)
                {
                    this.Formula.RemoveAt(comecoParentese);
                }

                bool resultado;
                try
                {
                    resultado = calcula(propParentese[0].getValor(), opParentese[0].ToCharArray()[0], propParentese[1].getValor());
                }
                catch (ArgumentOutOfRangeException e)
                {
                    resultado = propParentese[0].getValor();
                }

                for (int i = 1; i < parentese.Count - 1; i++)
                {
                    try
                    {
                        resultado = calcula(resultado, opParentese[i].ToCharArray()[0], propParentese[i + 1].getValor());
                    }
                    catch (ArgumentOutOfRangeException e) { }
                }

                if (resultado)
                {
                    this.Formula.Insert(comecoParentese, "true");
                }
                else
                {
                    this.Formula.Insert(comecoParentese, "false");
                }
            }
            catch (ArgumentOutOfRangeException e) { }
        }

        private Proposicao getProposicao(Char nome)
        {
            foreach (Proposicao i in this.proposicoes)
            {
                if (i.getNome().Equals(nome)) return i;
            }
            return null;
        }

        private bool calcula(bool a, Char op, bool b)
        {
            if (op.Equals(this.operadores[0].ToCharArray()[0]))
            {
                if (a && b) return true;

                return false;
            }

            else if (op.Equals(this.operadores[1].ToCharArray()[0]))
            {
                if (a || b) return true;

                return false;
            }

            else if (op.Equals(this.operadores[2].ToCharArray()[0]))
            {
                if (a && !b) return false;

                return true;
            }

            else if (op.Equals(this.operadores[3].ToCharArray()[0]))
            {
                if (a != b) return false;

                return true;
            }
            return false;
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