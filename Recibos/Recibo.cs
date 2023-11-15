namespace Recibos
{
    public class Recibo
    {
        #region Atributos

        private string nomeLocatario;
        private string enderecoImovel;
        private double valorPago;
        private DateTime dataPagamento;

        #endregion

        #region Propriedades

        public string NomeLocatario
        {
            get { return nomeLocatario; }
            set { nomeLocatario = value; }
        }

        public string EnderecoImovel
        {
            get { return enderecoImovel; }
            set { enderecoImovel = value; }
        }

        public double ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Recibos
        /// </summary>
        /// <param name="nomeLocatario"></param>
        /// <param name="enderecoImovel"></param>
        /// <param name="valorPago"></param>
        /// <param name="dataPagamento"></param>
        public Recibo(string nomeLocatario, string enderecoImovel, double valorPago, DateTime dataPagamento)
        {
            NomeLocatario = nomeLocatario;
            EnderecoImovel = enderecoImovel;
            ValorPago = valorPago;
            DataPagamento = dataPagamento;
        }

        #endregion
    }
}