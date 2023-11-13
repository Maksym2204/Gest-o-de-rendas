/*
 * 
 * criacao das funcoes relativas a class contrato em C#
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

using GestaoDeImoveis;

namespace GestaoDeContratos
{
    public static class OperacoesContrato
    {
        #region Funcoes
        /// <summary>
        /// Função para adicionar um novo contrato
        /// </summary>
        /// <param name="contratos"></param>
        /// <param name="imoveis"></param>
        public static void AdicionarContrato(List<Contrato> contratos, List<Imovel> imoveis)
        {
            Console.WriteLine("Adicionar contrato");
            Console.Write("ID do imóvel: ");
            int idImovel = int.Parse(Console.ReadLine());

            /// Verifica se o ID do imóvel é válido
            if (idImovel < 0 || idImovel >= imoveis.Count)
            {
                Console.WriteLine("ID do imóvel inválido!");
                return;
            }

            Imovel imovel = imoveis[idImovel];

            Console.Write("Data de início (dd/mm/aaaa): ");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Data de fim (dd/mm/aaaa): ");
            DateTime dataFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Nome do inquilino: ");
            string inquilino = Console.ReadLine();

            Console.Write("Valor mensal: ");
            double valorMensal = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(imovel, dataInicio, dataFim, inquilino, valorMensal);
            contratos.Add(contrato);

            /// Atualiza o estado do imóvel para alugado
            imovel.Estado = false;

            Console.WriteLine("Contrato adicionado com sucesso!");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Função para listar todos os Contratos
        /// </summary>
        /// <param name="contratos"></param>
        public static void ListarContratos(this List<Contrato> contratos)
        {
            Console.WriteLine("Lista de Contratos");

            foreach (Contrato contrato in contratos)
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
        #endregion
    }
}
