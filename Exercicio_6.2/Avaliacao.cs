using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public abstract class Avaliacao : IAvaliavel
    {
        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected double peso;
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        protected double notaObtida;
        public double NotaObtida
        {
            get { return notaObtida; }
            set { notaObtida = value; }
        }

        public Avaliacao()
        {
            nome = "Avaaliação";
            peso = 0;
            notaObtida = 0;
        }

        public Avaliacao(string nome, double peso)
        {
            this.nome = nome;
            this.peso = peso;
            this.notaObtida = 0;
        }

        public abstract double CalcularNotaFinal();
    }

}
