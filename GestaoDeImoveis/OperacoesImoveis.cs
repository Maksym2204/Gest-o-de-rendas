namespace GestaoDeImoveis
{
    public static class OperacoesImoveis
    {
        // Função de extenção da lista para adicionar um novo imóvel
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
        }

        // Função para listar todos os imóveis
        public static void ListarImoveis(this List<Imovel> imoveis)
        {
            Console.WriteLine("Lista de imóveis");
            Console.WriteLine("-----------------");

            foreach (Imovel imovel in imoveis)
            {
                Console.WriteLine($"Tipo: {imovel.Tipo}");
                Console.WriteLine($"Endereço: {imovel.Endereco}");
                Console.WriteLine($"Renda mensal: {imovel.RendaMensal}");
                Console.WriteLine($"Estado: {(imovel.Estado ? "Disponível" : "Alugado")}");
                Console.WriteLine();
            }
        }
    }
}
