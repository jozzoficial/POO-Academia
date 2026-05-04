using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class Estudante : Pessoa
    {
        private string curso;
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        private Dictionary<Avaliacao, double> notasAvaliacoes;

        public Estudante() : base()
        {
            curso = "indefinido";
            notasAvaliacoes = new Dictionary<Avaliacao, double>();
        }

        public Estudante(string nome, int numero, string curso) : base(nome, numero)
        {
            this.curso = curso;
            notasAvaliacoes = new Dictionary<Avaliacao, double>();
        }

        public void AdicionarNotaAvaliacao(Avaliacao avaliacao, double nota)
        {
            if (notasAvaliacoes.ContainsKey(avaliacao))
                notasAvaliacoes[avaliacao] = nota;
            else
                notasAvaliacoes.Add(avaliacao, nota);
        }

        public double ObterNotaAvaliacao(Avaliacao avaliacao)
        {
            if (notasAvaliacoes.ContainsKey(avaliacao))
                return notasAvaliacoes[avaliacao];
            return 0;
        }

        public double CalcularNotaFinal(List<Avaliacao> avaliacoes)
        {
            double notaFinal = 0;
            foreach (var avaliacao in avaliacoes)
            {
                if (notasAvaliacoes.ContainsKey(avaliacao))
                {
                    double nota = notasAvaliacoes[avaliacao];
                    double contribuicao = nota * avaliacao.Peso;
                    notaFinal += contribuicao;
                }
            }
            return notaFinal;
        }

        public override string ObterDados()
        {
            return $"Estudante - {base.ObterDados()}, Curso: {curso}";
        }
    }

}
