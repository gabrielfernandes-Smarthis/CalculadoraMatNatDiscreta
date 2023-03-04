using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMatNatDiscreta;

public class Calcular
{
    public List<string> Operadores { get; set; }

    public Calcular(List<string> operadores)
    {
        this.Operadores = operadores;
    }

    public bool calcula(bool a, Char op, bool b)
    {
        if (op.Equals(this.Operadores[0].ToCharArray()[0]))
        {
            if (a && b) return true;

            return false;
        }

        else if (op.Equals(this.Operadores[1].ToCharArray()[0]))
        {
            if (a || b) return true;

            return false;
        }

        else if (op.Equals(this.Operadores[2].ToCharArray()[0]))
        {
            if (a && !b) return false;

            return true;
        }

        else if (op.Equals(this.Operadores[3].ToCharArray()[0]))
        {
            if (a != b) return false;

            return true;
        }
        return false;
    }
}
