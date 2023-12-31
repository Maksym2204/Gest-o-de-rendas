/* Class: Gestor
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
    /// Classe que representa um gestor.
    /// </summary>
    public class Gestor : Pessoa
    {
        #region Atributos

        private string cargo;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o cargo do gestor.
        /// </summary>
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

     
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor para gestor.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nif"></param>
        /// <param name="cargo"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Gestor(string nome, string nif, string cargo, string telefone, string email)
            : base(nome, nif, telefone, email)
        {
            this.cargo = cargo;
        }

        #endregion
    }
}
