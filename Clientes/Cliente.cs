using PagamentoEntrada;

namespace Clientes
{
    public class Cliente
    {
        #region Atributos

        private string nome;
        private string endereco;
        private string telefone;
        private string email;
        private double entrada;
        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Clientes
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Cliente(string nome, string endereco, string telefone, string email, double entrada)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Entrada = 20000;
        }

        #endregion
    }
}