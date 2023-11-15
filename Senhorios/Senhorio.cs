namespace Senhorios
{
    public class Senhorio
    {
        #region Atributos

        private string nome;
        private string endereco;
        private string telefone;
        private string email;

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

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Senhorio
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Senhorio(string nome, string endereco, string telefone, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        #endregion
    }
}


