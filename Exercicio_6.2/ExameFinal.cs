using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class ExameFinal : Avaliacao
    {
        public ExameFinal() : base("Exame Final", 0.4) { }

        public ExameFinal(double peso) : base("Exame Final", peso) { }

        public override double CalcularNotaFinal()
        {
            return notaObtida * peso;
        }
    }
}
