namespace Exercicio_6._1
{
    public class Program
    {
        static void Main(string[] args)
        {
           GestorFrota manual = new();
            AddManual();

            menu();

            static void AddVeiculo(GestorFrota gestor)
            {
                try
                {
                    Console.WriteLine("ADICIONAR VEICULO:");

                    Console.Write("Matricula: ");
                    string Matricula = Console.ReadLine();

                    Console.Write("Marca: ");
                    string Marca = Console.ReadLine();

                    Console.Write("Modelo: ");
                    string Modelo = Console.ReadLine();

                    Console.Write("Ano de Fabricação: ");
                    int AnoFabricacao = int.Parse(Console.ReadLine());

                    Veiculo veiculo = new(Matricula, Marca, Modelo, AnoFabricacao, 0);

                    gestor.AdicionarVeiculo(veiculo);

                    Console.WriteLine("Cadasttrado com sucesso");

                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            void menu()
            {
                var executando = true;
                while (executando)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("\nSISTEMA DE ALUGUER DE AUTOMÓVEIS");
                    Console.WriteLine("1. Adicionar Veículos");
                    Console.WriteLine("2. Mostrar Frota");
                    Console.WriteLine("3. Actualizar KM (Pós-Aluguer)");
                    Console.WriteLine("0. Sair");
                    Console.Write("Escolha uma opção: ");
                    int escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            AddVeiculo(manual);
                            break;
                        case 2:
                            Console.Clear();
                            manual.ListarTodos(); break;
                        case 3:
                            Console.Clear();
                            Console.Write("Digite a matrícula: ");
                            string mat = Console.ReadLine();
                            Veiculo encontrado = manual.Buscar(mat);
                            if (encontrado != null)
                            {
                                Console.Write("Quantos KM foram percorridos no aluguer? ");
                                double km = double.Parse(Console.ReadLine());
                                encontrado.ActualizarQuilometragem(km);
                                Console.WriteLine("Quilometragem actualizada com sucesso");
                            }
                            else
                                Console.WriteLine("Veículo não encontrado.");
                            break;
                        case 0:
                            executando = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
            }

            void AddManual()
            {
                Veiculo veiculo1 = new("LD-22-44-AF", "Toyota", "Hilux", 2022, 15000.5);
                Veiculo veiculo2 = new("LD-10-99-MM", "Hyundai", "i10", 2023, 5000.0);
                Veiculo veiculo3 = new();
                veiculo3.Matricula = "LD-04-12-JS";
                veiculo3.Marca = "Suzuki";
                veiculo3.Modelo = "Jimny";
                veiculo3.AnoFabricacao = 2024;

                manual.AdicionarVeiculo(veiculo1);
                manual.AdicionarVeiculo(veiculo2);
                manual.AdicionarVeiculo(veiculo3);
            }
        }
    }
}
