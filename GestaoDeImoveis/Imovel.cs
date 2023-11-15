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

namespace Imoveis
{
    /// <summary>
    /// Classe para representar um imóvel
    /// </summary>
    public class Imovel
    {
        #region Atributos

        private string tipo;
        private string endereco;
        private double rendaMensal;
        private bool estado;

        #endregion

        #region Propriedades

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public double RendaMensal
        {
            get { return rendaMensal; }
            set { rendaMensal = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Imovel
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="endereco"></param>
        /// <param name="rendaMensal"></param>
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