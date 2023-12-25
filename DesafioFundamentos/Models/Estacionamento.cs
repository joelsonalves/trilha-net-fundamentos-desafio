namespace DesafioFundamentos.Models {
    public class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo() {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            if (placaVeiculo.Length == 0) Console.WriteLine("Nenhuma placa informada.");
            else if (veiculos.Contains(placaVeiculo)) Console.WriteLine("\nPlaca já cadastrada anteriormente.");
            else veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placaVeiculo = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper())) {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placaVeiculo);
                Console.WriteLine($"\nO veículo de placa \"{placaVeiculo}\" foi removido com sucesso.\nCusto total com estacionamento: R$ {valorTotal}.");
            } else {
                Console.WriteLine("\nVeículo não localizado. Por gentileza, conferir se a placa foi digitada corretamente.");
            }
        }

        public void ListarVeiculos() {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int cont = 1;
                foreach (string placaVeiculo in veiculos) {
                    Console.WriteLine($"{cont++} -> {placaVeiculo}");
                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
