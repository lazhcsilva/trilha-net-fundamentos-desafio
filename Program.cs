using estacionamento.Models;

namespace estacionamento
{
    class Program
    {
        static void Main(String[] args)
        {
        
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
            Console.WriteLine("Digite o preço inicial:");
            decimal valorInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora:");
            decimal valorPorHora = Convert.ToDecimal(Console.ReadLine());
            Estacionamento estacionamento = new Estacionamento(valorInicial, valorPorHora);
            Console.Clear();

            do
            {
                Menu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        estacionamento.CadastrarVeiculo();
                        break;
                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida, tente novamente");
                        break;
                }

            } while (true);
        }

        static void Menu()
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
        }
    }
}