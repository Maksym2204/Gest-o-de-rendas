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
                    Imoveis.ListarImoveis();
                    break;
                case 3:
                    OperacoesContrato.AdicionarContrato(Contratos, Imoveis);
                    break;
                case 4:
                    Contratos.ListarContratos();
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
}