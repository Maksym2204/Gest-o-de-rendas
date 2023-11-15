namespace Despesas
{
    public class Despesa
    {
        #region Atributos

        private string descricao;
        private double valor;
        private DateTime dataVencimento;
        private bool pago;

        #endregion

        #region Propriedades

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Despesas
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="valor"></param>
        /// <param name="dataVencimento"></param>
        public Despesa(string descricao, double valor, DateTime dataVencimento)
        {
            Descricao = descricao;
            Valor = valor;
            DataVencimento = dataVencimento;
            Pago = false; // A despesa é considerada não paga inicialmente
        }

        #endregion
    }
}