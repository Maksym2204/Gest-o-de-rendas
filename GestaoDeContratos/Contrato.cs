/*
 * 
 * criacao da class e construtor da classe contrato em C#
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
    /// <summary>
    /// Classe para representar um contrato de aluguer
    /// </summary>
    public class Contrato
    {
        #region Propriedades
        public Imovel Imovel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Inquilino { get; set; }
        public double ValorMensal { get; set; }

        #endregion
        /// <summary>
        /// Construtor da classe Contrato
        /// </summary>
        /// <param name="imovel"></param>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="inquilino"></param>
        /// <param name="valorMensal"></param>
        #region Construtores
        public Contrato(Imovel imovel, DateTime dataInicio, DateTime dataFim, string inquilino, double valorMensal)
        {
            Imovel = imovel;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Inquilino = inquilino;
            ValorMensal = valorMensal;
        }
        #endregion
    }
}