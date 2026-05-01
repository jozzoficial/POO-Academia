using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6._1
{
    public class GestorFrota
    {
        private List<Veiculo> frota = new List<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo) => frota.Add(veiculo);

        public void ListarTodos()
        {
            Console.WriteLine("\nLISTA DE VEÍCULOS NA FROTA:");
            foreach (var veiculo in frota) 
            {
                veiculo.ApresentarDados();
            }
            
        }

        public Veiculo Buscar(string matricula)
        {
            return frota.Find(veiculo => veiculo.Matricula.ToUpper() == matricula.ToUpper());
        }
    }
}
