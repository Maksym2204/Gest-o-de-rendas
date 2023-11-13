/*
 * 
 * Criacao de uma main em C# com o objetivo de verificar  a funcionalidade de todas as funcoes existentes no programa
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

using GestaoDeContratos;
using GestaoDeImoveis;

namespace DomiGest;

public class Program
{   
    /// <summary>
    /// Declaracao de duas variaveis estaticas
    /// </summary>
    private static List<Imovel> Imoveis = new List<Imovel>(); // Lista de imóveis
    private static List<Contrato> Contratos = new List<Contrato>(); // Lista de Contratos

    static void Main(string[] args)
    {
        ///Execusao da funcao Adicionar imovel
        Imoveis.AdicionarImovel();

        ///Execusao da funcao Listar imóveis
        Imoveis.ListarImoveis();

        ///Execusao da funcao Adicionar contrato
        OperacoesContrato.AdicionarContrato(Contratos, Imoveis);

        ///Execusao da funcao Listar contratos
        Contratos.ListarContratos();

        ///Execusao da funcao Listar imóveis de novo para verificacao da mudanca na variavel estado
        Imoveis.ListarImoveis();

        ///Escreve a mensaguem final
        Console.WriteLine("Obrigado por utilizar o programa!");
    }
}