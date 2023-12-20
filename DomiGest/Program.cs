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

using Caracteristicas;
using DataTempo;
using Imoveis;
using Locais;
using Pagamentos;
using RecursosHumanos;

namespace DomiGest;

public class Program
{   
    public static void Main(string[] args)
    {
        Prestacao prestacao = new Prestacao(500);
        Inquilino inquilino1 = new Inquilino("Joao Pedro","Rua dos Papagaios","123456789","911777222","JoaoP@gmail.com",prestacao,48);
        //Caracteristica caracteristica = new Caracteristica(2, 2, true, 84.4, false, true);
        //Local localDoPorto = new Local("Rua da Alegria", "Porto", "Portugal", "4000-000");
        //Imovel imovel1 = new Imovel(TipoImovel.Apartamento, localDoPorto, "", caracteristica, true, senhorio, null, null, 30);
    }
}