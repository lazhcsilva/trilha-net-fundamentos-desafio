namespace estacionamento.Models
{
    public class Estacionamento
    {

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("Informe a placa do veiculo para estacionar");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            FinalizarOperacao();
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string removerPlaca = Console.ReadLine();
                string veiculo = veiculos.Find(v => v == removerPlaca);
                while (veiculo == null)
                {
                    Console.WriteLine("Não foi encontrado placa com esse registro!");
                    Console.WriteLine("Digite a placa do veículo para remover");
                    removerPlaca = Console.ReadLine();
                    veiculo = veiculos.Find(v => v == removerPlaca);
                }
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int qtdHoras = Convert.ToInt32(Console.ReadLine());
                veiculos.Remove(removerPlaca);
                Console.WriteLine($"O veículo {removerPlaca} foi removido e preço total foi de {CalcularValorPagamento(qtdHoras):C}");
                FinalizarOperacao();
            }
            else
            {
                Console.WriteLine("Não há veículos estacinados");
                FinalizarOperacao();
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veiculos estacionados são:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
                FinalizarOperacao();
            }
            else
            {
                Console.WriteLine("Não há veículos estacinados");
                FinalizarOperacao();
            }
        }

        private decimal CalcularValorPagamento(int qtdHoras)
        {
            return precoInicial + (precoPorHora * qtdHoras);
        }

        private void FinalizarOperacao()
        {
            Console.WriteLine("Digite uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}