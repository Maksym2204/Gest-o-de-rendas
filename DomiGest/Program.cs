using GestaoDeContratos;
using GestaoDeImoveis;

namespace DomiGest;

public class Program
{
    private static List<Imovel> Imoveis = new List<Imovel>(); // Lista de imóveis
    private static List<Contrato> Contratos = new List<Contrato>(); // Lista de Contratos

    static void Main(string[] args)
    {
        // Exemplo de utilização das funcionalidades do programa

        // Adicionar imóvel
        Imoveis.AdicionarImovel();

        // Listar imóveis
        Imoveis.ListarImoveis();

        // Adicionar contrato
        OperacoesContrato.AdicionarContrato(Contratos, Imoveis);

        // Listar contratos
        Contratos.ListarContratos();

        Console.WriteLine("Obrigado por utilizar o programa!");
    }
}