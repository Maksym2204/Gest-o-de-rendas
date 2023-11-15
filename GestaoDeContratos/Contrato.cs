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
        #region Atributos

        private Imovel imovel;
        private DateTime dataInicio;
        private DateTime dataFim;
        private string inquilino;
        private double valorMensal;

        #endregion

        #region Propriedades

        public Imovel Imovel
        {
            get { return imovel; }
            set { imovel = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public string Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }

        public double ValorMensal
        {
            get { return valorMensal; }
            set { valorMensal = value; }
        }

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