/*
 * 
 * criacao da class e construtor da classe imovel em C#
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

namespace GestaoDeImoveis
{
    /// <summary>
    /// Classe para representar um imóvel
    /// </summary>
    public class Imovel
    {
        #region Atributos
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public double RendaMensal { get; set; }
        public bool Estado { get; set; }
        #endregion
        /// <summary>
        /// Construtor da classe Imovel
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="endereco"></param>
        /// <param name="rendaMensal"></param>
        #region Construtor
        public Imovel(string tipo, string endereco, double rendaMensal)
        {
            Tipo = tipo;
            Endereco = endereco;
            RendaMensal = rendaMensal;
            Estado = true; /// Imóvel está disponível para aluguer inicialmente
        }
        #endregion
    }
}