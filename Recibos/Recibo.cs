/* Class: Recibos
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace Recibos
{
    /// <summary>
    /// Classe que representa um recibo de pagamento.
    /// </summary>
    public abstract class Recibo
    {
        #region Atributos

        private string nomeLocatario;
        private string enderecoImovel;
        private double valorPago;
        private DateTime dataPagamento;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do locatário.
        /// </summary>
        public string NomeLocatario
        {
            get { return nomeLocatario; }
            set { nomeLocatario = value; }
        }

        /// <summary>
        /// Obtém ou define o endereço do imóvel.
        /// </summary>
        public string EnderecoImovel
        {
            get { return enderecoImovel; }
            set { enderecoImovel = value; }
        }

        /// <summary>
        /// Obtém ou define o valor pago.
        /// </summary>
        public double ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }

        /// <summary>
        /// Obtém ou define a data do pagamento.
        /// </summary>
        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Recibo.
        /// </summary>
        /// <param name="nomeLocatario">O nome do locatário.</param>
        /// <param name="enderecoImovel">O endereço do imóvel.</param>
        /// <param name="valorPago">O valor pago.</param>
        /// <param name="dataPagamento">A data do pagamento.</param>
        public Recibo(string nomeLocatario, string enderecoImovel, double valorPago, DateTime dataPagamento)
        {
            NomeLocatario = nomeLocatario;
            EnderecoImovel = enderecoImovel;
            ValorPago = valorPago;
            DataPagamento = dataPagamento;
        }

        #endregion

        #region Métodos

        public abstract void EmitirRecibo();

        #endregion
    }
}
