using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class Assistente : Docente
    {
        public Assistente() : base() { }

        public Assistente(string nome, int numero, string areaEspecializacao) : base(nome, numero, areaEspecializacao) { }

        public override string ObterDados()
        {
            return $"Docente Assistente - {base.ObterDados()}";
        }
    }
}
