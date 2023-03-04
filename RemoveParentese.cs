using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta
{
    public class RemoveParentese
    {
        public List<string> Formula { get; set; }
        public PegaProposicao preposicoes { get; set; }
        public Calcular calcular { get; set; }

        public RemoveParentese(List<string> formula, PegaProposicao pegaProposicao, Calcular objCalcular)
        {
            this.Formula = formula;
            this.preposicoes = pegaProposicao;
            this.calcular = objCalcular;
        }

        public List<string> executaParenteses()
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
                            n.setValor(!preposicoes.getProposicao(parentese[i + 1].ToCharArray()[0]).getValor());
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
                            propParentese.Add(preposicoes.getProposicao(parentese[i].ToCharArray()[0]));
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
                    resultado = calcular.calcula(propParentese[0].getValor(), opParentese[0].ToCharArray()[0], propParentese[1].getValor());
                }
                catch (ArgumentOutOfRangeException e)
                {
                    resultado = propParentese[0].getValor();
                }

                for (int i = 1; i < parentese.Count - 1; i++)
                {
                    try
                    {
                        resultado = calcular.calcula(resultado, opParentese[i].ToCharArray()[0], propParentese[i + 1].getValor());
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
                return this.Formula;
            }
            catch (ArgumentOutOfRangeException e) 
            {
                return null;
            }
        }
    }
}
