using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class Titular : Docente
    {
        public Titular() : base() { }

        public Titular(string nome, int numero, string areaEspecializacao) : base(nome, numero, areaEspecializacao) { }

        public override string ObterDados()
        {
            return $"Docente Titular - {base.ObterDados()}";
        }
    }
}
