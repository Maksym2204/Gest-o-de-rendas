/* Class: Despesas
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace Despesas
{
    /// <summary>
    /// Representa uma despesa.
    /// </summary>
    public class Despesa
    {
        #region Atributos

        private string descricao;
        private double valor;
        private DateTime dataVencimento;
        private bool pago;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define a descrição da despesa.
        /// </summary>
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Obtém ou define o valor da despesa.
        /// </summary>
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Obtém ou define a data de vencimento da despesa.
        /// </summary>
        public DateTime DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        /// <summary>
        /// Obtém ou define se a despesa foi paga.
        /// </summary>
        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Despesa.
        /// </summary>
        /// <param name="descricao">A descrição da despesa.</param>
        /// <param name="valor">O valor da despesa.</param>
        /// <param name="dataVencimento">A data de vencimento da despesa.</param>
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
