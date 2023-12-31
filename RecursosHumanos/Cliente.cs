/* Class: Cliente
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
    /// Classe que representa um cliente.
    /// </summary>
    public class Cliente : Pessoa, ISaldo
    {
        #region Atributos

        private double saldo;

        #endregion

        #region Propriedades

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Cliente.
        /// </summary>
        /// <param name="nome">O nome do cliente.</param>
        /// <param name="nif">O NIF do cliente.</param>
        /// <param name="telefone">O telefone do cliente.</param>
        /// <param name="email">O email do cliente.</param>
        /// <param name="entrada">O valor da entrada do cliente.</param>
        public Cliente(string nome, string nif, string telefone, string email)
            : base(nome, nif, telefone, email)
        {
            this.saldo = 0;
        }

        public void RetirarSaldo(double valor)
        {
            if (saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }

            saldo -= valor;
        }

        public void AdcionarSaldo(double valor)
        {
            saldo += valor;
        }

        #endregion
    }
}
