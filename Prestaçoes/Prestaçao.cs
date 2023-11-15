namespace Prestaçoes
{
    public class Prestaçao
    {
        #region Atributos

        private DateTime dataVencimento;
        private double valorPrestacao;
        private bool pago;

        #endregion

        #region Propriedades

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public double ValorPrestacao
        {
            get { return valorPrestacao; }
            set { valorPrestacao = value; }
        }

        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Prestacoes
        /// </summary>
        /// <param name="dataVencimento"></param>
        /// <param name="valorPrestacao"></param>
        public Prestaçao(DateTime dataVencimento, double valorPrestacao)
        {
            DataVencimento = dataVencimento;
            ValorPrestacao = valorPrestacao;
            Pago = false; // A prestação é considerada não paga inicialmente
        }

        #endregion
    }
}