using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class Projeto : Avaliacao
    {
        public Projeto() : base("Projeto", 0.3) { }

        public Projeto(double peso) : base("Projeto", peso) { }

        public override double CalcularNotaFinal()
        {
            return notaObtida * peso;
        }
    }
}
