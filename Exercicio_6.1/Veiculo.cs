using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._1
{
    public class Veiculo
    {
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int anoFabricacao;
        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        private double quilometragem;
        public double Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }


        public Veiculo() { }

        public Veiculo(string matricula, string marca, string modelo, int ano, double km)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = ano;
            this.quilometragem = km;
        }

        public void ActualizarQuilometragem(double kmPercorrida)
        {
            if (kmPercorrida > 0)
                this.quilometragem += kmPercorrida;
            else
                Console.WriteLine("Erro: A quilometragem percorrida deve ser positiva.");
        }

        public void ApresentarDados()
        {
            Console.WriteLine($"Matrícula: {Matricula} | {Marca} {Modelo} ({AnoFabricacao}) | KM: {Quilometragem}");
        }
    }
}
