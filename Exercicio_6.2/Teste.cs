using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class Teste : Avaliacao
    {
        public Teste() : base("Teste", 0.3) { }

        public Teste(double peso) : base("Teste", peso) { }

        public override double CalcularNotaFinal()
        {
            return notaObtida * peso;
        }
    }

}
