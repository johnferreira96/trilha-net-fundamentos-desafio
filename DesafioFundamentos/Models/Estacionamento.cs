using System;
using System.Collections.Generic;
using System.Linq;


namespace DesafioFundamentos.Models
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


        public void AdicionarVeiculo()
        {


            // Utilizando Console.ReadLine() para obter a placa dos veicolos


            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com a placa {placa} estacionado com sucesso.");
        }


        public void RemoverVeiculo()
        {
             Console.WriteLine("Veículos estacionados:");
    
            // Exibir a lista de veículos antes de selecionar os veículos para remover
            
            ListarVeiculos();


            Console.WriteLine("Digite a placa do veículo para remover:");


            // Utilizando o Console.ReadLine como parâmentro para remover o veículos cadastrados
           
            string placa = Console.ReadLine();


            // Verifica se o veículo existe


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                // Colocando o metodo if else para receber a quatidade de horas que o veículo permaneceu estacionado e uzando o TryParse
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + (precoPorHora * horas);


                    // Utizando o metodo Remove para remover o veículo cadastrado


                    veiculos.Remove(placa);


                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {


                    // Utilizei o else para dar mais valor as informações dadas, caso as horas sejam digitadas erradas


                    Console.WriteLine("Quantidade de horas inválida. Remoção cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }


        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");


                // Utilizando o foreach para listar as placas cadastradas


                foreach (var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
