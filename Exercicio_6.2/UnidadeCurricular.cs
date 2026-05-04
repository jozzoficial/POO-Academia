using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._2
{
    public class UnidadeCurricular
    {
        private string codigo;
        private string nome;
        private Docente docenteResponsavel;
        private List<Estudante> estudantesInscritos;  
        private List<Avaliacao> avaliacoes;      

        public UnidadeCurricular()
        {
            codigo = "UC000";
            nome = "Unidade Curricular";
            docenteResponsavel = null;
            estudantesInscritos = new List<Estudante>();
            avaliacoes = new List<Avaliacao>();
        }

        public UnidadeCurricular(string codigo, string nome, Docente docente)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.docenteResponsavel = docente;
            estudantesInscritos = new List<Estudante>();
            avaliacoes = new List<Avaliacao>();
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Docente DocenteResponsavel
        {
            get { return docenteResponsavel; }
            set { docenteResponsavel = value; }
        }

        public void AdicionarEstudante(Estudante estudante)
        {
            if (!estudantesInscritos.Contains(estudante))
            {
                estudantesInscritos.Add(estudante);
                Console.WriteLine($"Estudante {estudante.Nome} inscrito na UC {nome}");
            }
            else
            {
                Console.WriteLine($"Estudante {estudante.Nome} já está inscrito nesta UC");
            }
        }

        public void RemoverEstudante(Estudante estudante)
        {
            if (estudantesInscritos.Contains(estudante))
            {
                estudantesInscritos.Remove(estudante);
                Console.WriteLine($"Estudante {estudante.Nome} removido da UC {nome}");
            }
        }

        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacoes.Add(avaliacao);
            Console.WriteLine($"Avaliação '{avaliacao.Nome}' (Peso: {avaliacao.Peso:P}) adicionada à UC {nome}");
        }

        public void AtribuirNotasEstudante(Estudante estudante, Avaliacao avaliacao, double nota)
        {
            if (estudantesInscritos.Contains(estudante) && avaliacoes.Contains(avaliacao))
            {
                estudante.AdicionarNotaAvaliacao(avaliacao, nota);
                avaliacao.NotaObtida = nota;
                Console.WriteLine($"Nota {nota} atribuída ao estudante {estudante.Nome} na avaliação {avaliacao.Nome}");
            }
            else
            {
                Console.WriteLine("Estudante não inscrito ou avaliação não encontrada");
            }
        }

        public void EmitirPauta()
        {
            Console.WriteLine($"PAUTA DE CLASSIFICAÇÕES - {nome} ({codigo})");
            Console.WriteLine($"Docente Responsável: {docenteResponsavel?.ObterDados()}");

            if (estudantesInscritos.Count == 0)
            {
                Console.WriteLine("Sem estudantes inscritos.");
                return;
            }

            if (avaliacoes.Count == 0)
            {
                Console.WriteLine("Sem avaliações definidas.");
                return;
            }

            var pauta = new List<Tuple<Estudante, double>>();

            foreach (var estudante in estudantesInscritos)
            {
                double notaFinal = 0;
                foreach (var avaliacao in avaliacoes)
                {
                    double notaAvaliacao = estudante.ObterNotaAvaliacao(avaliacao);
                    double contribuicao = notaAvaliacao * avaliacao.Peso;
                    notaFinal += contribuicao;
                }
                pauta.Add(Tuple.Create(estudante, notaFinal));
            }

            pauta = pauta.OrderByDescending(t => t.Item2).ToList();

            Console.WriteLine($"{"Numerp",-6} {"Estudante",-25} {"Curso",-20} {"Nota Final",-10}");

            foreach (var item in pauta)
            {
                Console.WriteLine($"{item.Item1.Numero,-6} {item.Item1.Nome,-25} {item.Item1.Curso,-20} {item.Item2:F2}");
            }

            double mediaTurma = pauta.Average(t => t.Item2);
            Console.WriteLine($"Média da turma: {mediaTurma:F2}");
        }

        public void ListarAvaliacoes()
        {
            Console.WriteLine($"Avaliações da UC {nome}:");
            int i = 1;
            foreach (var av in avaliacoes)
            {
                Console.WriteLine($"{i++}. {av.Nome} - Peso: {av.Peso:P}");
            }
        }

        public List<Estudante> ObterEstudantesInscritos()
        {
            return estudantesInscritos;
        }

        public List<Avaliacao> ObterAvaliacoes()
        {
            return avaliacoes;
        }
    }
}
