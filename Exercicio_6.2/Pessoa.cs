using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public abstract class Pessoa
    {
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Pessoa()
        {
            nome = " ";
            numero = 0;
        }

        public Pessoa(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
        }

        public virtual string ObterDados()
        {
            return $"Nome: {nome}, Número: {numero}";
        }
    }
}
