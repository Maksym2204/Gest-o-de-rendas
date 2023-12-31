/* Class: Pagamentos
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
    /// Classe que representa uma entrada de pagamento.
    /// </summary>
    public class Entrada : Pagamento
    {
        #region Atributos

        private Cliente cliente;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Entrada.
        /// </summary>
        /// <param name="clienteNome">O nome do cliente.</param>
        /// <param name="valor">O valor da entrada.</param>
        /// <param name="dataPagamento">A data do pagamento.</param>
        public Entrada(double valor, DateTime dataPagamento, Cliente cliente):base(valor,dataPagamento)
        {
            this.cliente = cliente;
        }

        #endregion
    }
}
