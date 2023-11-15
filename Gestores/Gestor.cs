using Despesas;
using Recibos;
using Serviços;

namespace Gestores
{
    public class Gestor
    {
        #region Atributos

        private string nome;
        private string cargo;
        private string telefone;
        private string email;
        private Despesa despesa;
        private Recibo recibo;
        private Serviço serviço;


        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
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

        public Despesa Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }

        public Recibo Recibo
        {
            get { return recibo; }
            set { recibo = value; }
        }
        public Serviço Serviço
        {
            get { return serviço; }
            set { serviço = value; }
        }
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Gestores
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cargo"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Gestor(string nome, string cargo, string telefone, string email, Despesa despesa,Recibo recibo, Serviço serviço)
        {
            Nome = nome;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
            Despesa Despesa = despesa;
            Recibo Recibo = recibo;
            Serviço = serviço;
        }

        #endregion
    }
}