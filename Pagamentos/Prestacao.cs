/* Class:Prestacao
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

using RecursosHumanos;

namespace Pagamentos
{
    /// <summary>
    /// Classe que representa uma prestação de pagamento.
    /// </summary>
    public class Prestacao : Pagamento
    {
        #region Atributos
        private Inquilino inquilino;

        #endregion

        #region Propriedades

        public Inquilino Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }

        #endregion

        #region Métodos


        /// <summary>
        /// Efetua o pagamento da prestação.
        /// </summary>
        /// <param name="diferenca">A data da última prestação.</param>
        /// <param name="saldo">O saldo do inquilino.</param>
        /// <param name="inquilino">O inquilino.</param>
        public void PagarPrestacao( Inquilino inquilino, double valor)
        {
            inquilino.RetirarSaldo(valor);
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Prestacao.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="dataPagamento"></param>
        /// <param name="inquilino"></param>
        public Prestacao(double valor, DateTime dataPagamento, Inquilino inquilino) : base(valor, dataPagamento)
        {
            this.inquilino = inquilino;
        }

        #endregion
    }
}
