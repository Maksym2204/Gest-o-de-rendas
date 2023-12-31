/* Class: Pessoa
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
    /// Classe que representa uma pessoa.
    /// </summary>
    public class Pessoa
    {
        #region Atributos

        private string nome;
        private string nif;
        private string telefone;
        private string email;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome da pessoa.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define o NIF (Número de Identificação Fiscal) da pessoa.
        /// </summary>
        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }

        /// <summary>
        /// Obtém ou define o telefone da pessoa.
        /// </summary>
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        /// <summary>
        /// Obtém ou define o email da pessoa.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Pessoa.
        /// </summary>
        /// <param name="nome">O nome da pessoa.</param>
        /// <param name="nif">O NIF (Número de Identificação Fiscal) da pessoa.</param>
        /// <param name="telefone">O telefone da pessoa.</param>
        /// <param name="email">O email da pessoa.</param>
        public Pessoa(string nome, string nif, string telefone, string email)
        {
            this.nome = nome;
            this.nif = nif;
            this.telefone = telefone;
            this.email = email;
        }

        #endregion
    }
}
