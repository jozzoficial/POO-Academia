using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public abstract class Docente : Pessoa
    {
        protected string areaEspecializacao;
        public string AreaEspecializacao
        {
            get { return areaEspecializacao; }
            set { areaEspecializacao = value; }
        }

        public Docente() : base()
        {
            areaEspecializacao = "indefinida";
        }

        public Docente(string nome, int numero, string areaEspecializacao) : base(nome, numero)
        {
            this.areaEspecializacao = areaEspecializacao;
        }


        public override string ObterDados()
        {
            return base.ObterDados() + $", Área: {areaEspecializacao}";
        }
    }
}
