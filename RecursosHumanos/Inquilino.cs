/* Class: Inquilino
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace RecursosHumanos
{
    /// <summary>
    /// Classe que representa um inquilino.
    /// </summary>
    public class Inquilino : Pessoa, ISaldo
    {
        #region Atributos

        private string endereco;
        private double saldo;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o saldo do inquilino.
        /// </summary>
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        /// <summary>
        /// Obtém ou define o endereço do inquilino.
        /// </summary>
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Retira um valor do saldo do inquilino.
        /// </summary>
        /// <param name="valor">O valor a ser retirado.</param>
        /// <returns>O novo saldo após a retirada.</returns>
        public void RetirarSaldo(double valor)
        {
            this.saldo -= valor;
        }

        /// <summary>
        /// Deposita um valor no saldo do inquilino.
        /// </summary>
        /// <param name="valor">O valor a ser depositado.</param>
        /// <returns>O novo saldo após o depósito.</returns>
        public void DepositarSaldo(double valor)
        {
            this.Saldo += valor;
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Inquilino.
        /// </summary>
        /// <param name="nome">O nome do inquilino.</param>
        /// <param name="endereco">O endereço do inquilino.</param>
        /// <param name="nif">O NIF do inquilino.</param>
        /// <param name="telefone">O telefone do inquilino.</param>
        /// <param name="email">O email do inquilino.</param>
        /// <param name="numeroMensalidades">O número de mensalidades do inquilino.</param>
        public Inquilino(string nome, string endereco, string nif, string telefone, string email)
            : base(nome, nif, telefone, email)
        {
            this.endereco = endereco;
            this.saldo = 0;
        }

        #endregion
    }
}
