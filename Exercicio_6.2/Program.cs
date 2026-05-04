using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA UNIVERSITÁRIO\n");

            Titular professorTitular = new Titular("Ventura Nsaku", 1001, "Algoritmos");
            Assistente professorAssistente = new Assistente("João José", 1002, "Matemática");

            Console.WriteLine("DOCENTES CADASTRADOS:");
            Console.WriteLine(professorTitular.ObterDados());
            Console.WriteLine(professorAssistente.ObterDados());
            Console.WriteLine();

            Estudante estudante1 = new Estudante("JPedro Bengui", 2024001, "Engenharia Informática");
            Estudante estudante2 = new Estudante("Arnaldo Santos", 2024002, "Engenharia Informática");
            Estudante estudante3 = new Estudante("Francisco Bráulio", 2024003, "Matemática Aplicada");
            Estudante estudante4 = new Estudante("Kumbi Anjo", 2024004, "Engenharia Informática");

            Console.WriteLine("ESTUDANTES CRIADOS:");
            Console.WriteLine(estudante1.ObterDados());
            Console.WriteLine(estudante2.ObterDados());
            Console.WriteLine(estudante3.ObterDados());
            Console.WriteLine(estudante4.ObterDados());
            Console.WriteLine();

            UnidadeCurricular ucPOO = new UnidadeCurricular("POO2026", "Programação Orientada a Objetos", professorTitular);

;
            Teste teste = new Teste(0.25);
            Projeto projeto = new Projeto(0.35);
            ExameFinal exame = new ExameFinal(0.40);

            ucPOO.AdicionarAvaliacao(teste);
            ucPOO.AdicionarAvaliacao(projeto);
            ucPOO.AdicionarAvaliacao(exame);

            Console.WriteLine();
            ucPOO.ListarAvaliacoes();
            Console.WriteLine();

            ucPOO.AdicionarEstudante(estudante1);
            ucPOO.AdicionarEstudante(estudante2);
            ucPOO.AdicionarEstudante(estudante3);
            ucPOO.AdicionarEstudante(estudante4);
            Console.WriteLine();

            ucPOO.AtribuirNotasEstudante(estudante1, teste, 15.5);
            ucPOO.AtribuirNotasEstudante(estudante1, projeto, 17.0);
            ucPOO.AtribuirNotasEstudante(estudante1, exame, 14.0);

            ucPOO.AtribuirNotasEstudante(estudante2, teste, 18.0);
            ucPOO.AtribuirNotasEstudante(estudante2, projeto, 19.0);
            ucPOO.AtribuirNotasEstudante(estudante2, exame, 17.5);

            ucPOO.AtribuirNotasEstudante(estudante3, teste, 12.0);
            ucPOO.AtribuirNotasEstudante(estudante3, projeto, 13.0);
            ucPOO.AtribuirNotasEstudante(estudante3, exame, 11.0);

            ucPOO.AtribuirNotasEstudante(estudante4, teste, 16.0);
            ucPOO.AtribuirNotasEstudante(estudante4, projeto, 14.5);
            ucPOO.AtribuirNotasEstudante(estudante4, exame, 15.0);
            Console.WriteLine();

            ucPOO.EmitirPauta();

            List<IAvaliavel> avaliacoesLista = new List<IAvaliavel>
            {
                new Teste(0.25),
                new Projeto(0.35),
                new ExameFinal(0.40)
            };

            foreach (var av in avaliacoesLista)
            {
                Avaliacao a = (Avaliacao)av;
                a.NotaObtida = 15.0;
                Console.WriteLine($"{a.Nome} com nota 15 e peso {a.Peso:P} contribui com {a.CalcularNotaFinal():F2} para a nota final");
            }

        }
    }
}