namespace PagamentoEntrada
{
 
    public class Entrada
    {
        #region Atributos

        private string clienteNome;
        private double valor;
        private DateTime dataPagamento;

        #endregion

        #region Propriedades

        public string ClienteNome
        {
            get { return clienteNome; }
            set { clienteNome = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe PagamentoEntrada
        /// </summary>
        /// <param name="clienteNome"></param>
        /// <param name="valor"></param>
        /// <param name="dataPagamento"></param>
        public Entrada(string clienteNome, double valor, DateTime dataPagamento)
        {
            ClienteNome = clienteNome;
            Valor = valor;
            DataPagamento = dataPagamento;
        }

        #endregion
    }
}