using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta;

public class VerificarFBF
{
    public List<string> Formula { get; set; }
    public List<string> operadores { get; set; }

    public VerificarFBF(List<string> formula, List<string> Operadores)
    {
        this.Formula = formula;
        this.operadores = Operadores;
    }

    public bool isFBF()
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
}
