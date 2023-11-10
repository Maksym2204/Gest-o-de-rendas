using System;
using System.Collections.Generic;

namespace IPCAGest
{
    class Program
    {
        private static List<Imovel> Imoveis = new List<Imovel>(); // Lista de imóveis
        private static List<Contrato> Contratos = new List<Contrato>(); // Lista de Contratos

        static void Main(string[] args)
        {
            // Exemplo de utilização das funcionalidades do programa
            while (true)
            {
                Console.WriteLine("1 - Adicionar imóvel");
                Console.WriteLine("2 - Listar imóveis");
                Console.WriteLine("3 - Adicionar contrato");
                Console.WriteLine("4 - Listar Contratos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Imoveis.AdicionarImovel();
                        break;
                    case 2:
                        OperacoesImoveis.ListarImoveis(Imoveis);
                        break;
                    case 3:
                        AdicionarContrato();
                        break;
                    case 4:
                        ListarContratos();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por utilizar o programa!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // Função para adicionar um novo contrato
        static void AdicionarContrato()
        {
            Console.WriteLine("Adicionar contrato");
            Console.Write("ID do imóvel: ");
            int idImovel = int.Parse(Console.ReadLine());

            // Verifica se o ID do imóvel é válido
            if (idImovel < 0 || idImovel >= Imoveis.Count)
            {
                Console.WriteLine("ID do imóvel inválido!");
                return;
            }

            Imovel imovel = Imoveis[idImovel];

            Console.Write("Data de início (dd/mm/aaaa): ");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Data de fim (dd/mm/aaaa): ");
            DateTime dataFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Nome do inquilino: ");
            string inquilino = Console.ReadLine();

            Console.Write("Valor mensal: ");
            double valorMensal = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(imovel, dataInicio, dataFim, inquilino, valorMensal);
            Contratos.Add(contrato);

            // Atualiza o estado do imóvel para alugado
            imovel.Estado = false;

            Console.WriteLine("Contrato adicionado com sucesso!");
        }

        // Função para listar todos os Contratos
        static void ListarContratos()
        {
            Console.WriteLine("Lista de Contratos");
            Console.WriteLine("------------------");

            foreach (Contrato contrato in Contratos)
            {
                Console.WriteLine($"Imóvel: {contrato.Imovel.Tipo}");
                Console.WriteLine($"Endereço: {contrato.Imovel.Endereco}");
                Console.WriteLine($"Data de início: {contrato.DataInicio.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Data de fim: {contrato.DataFim.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Inquilino: {contrato.Inquilino}");
                Console.WriteLine($"Valor mensal: {contrato.ValorMensal}");
                Console.WriteLine();
            }
        }
    }
}