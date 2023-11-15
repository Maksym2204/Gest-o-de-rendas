/*
 * 
 * criacao das funcoes relativas a class imovel em C#
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

namespace GestaoDeImoveis
{
    public static class OperacoesImoveis
    {
        #region Funcoes
        /// <summary>
        /// Função de extenção da lista para adicionar um novo imóvel
        /// </summary>
        /// <param name="imoveis"></param>
        public static void AdicionarImovel(this List<Imovel> imoveis)
        {
            Console.WriteLine("Adicionar imóvel");
            Console.Write("Tipo de imóvel (apartamento, vivenda, terreno): ");
            string tipo = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Renda mensal: ");
            double rendaMensal = double.Parse(Console.ReadLine());

            Imovel imovel = new Imovel(tipo, endereco, rendaMensal);
            imoveis.Add(imovel);

            Console.WriteLine("Imóvel adicionado com sucesso!");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Função para listar todos os imóveis
        /// </summary>
        /// <param name="imoveis"></param>
        public static void ListarImoveis(this List<Imovel> imoveis)
        {
            Console.WriteLine("Lista de imóveis");

            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine($"Tipo: {imovel.Tipo}");
                Console.WriteLine($"Endereço: {imovel.Endereco}");
                Console.WriteLine($"Renda mensal: {imovel.RendaMensal}");
                Console.WriteLine($"Estado: {(imovel.Estado ? "Disponível" : "Alugado")}");
                Console.WriteLine();
            }
        }
        #endregion
    }
}