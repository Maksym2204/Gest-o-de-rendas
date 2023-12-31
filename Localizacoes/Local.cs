/* Class: Locais
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace Locais
{
    /// <summary>
    /// Classe que representa um local.
    /// </summary>
    public class Local
    {
        #region Atributos

        private string endereco;
        private string cidade;
        private string pais;
        private string postal;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o endereço.
        /// </summary>
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /// <summary>
        /// Obtém ou define a cidade.
        /// </summary>
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        /// <summary>
        /// Obtém ou define o país.
        /// </summary>
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        /// <summary>
        /// Obtém ou define o código postal.
        /// </summary>
        public string Postal
        {
            get { return postal; }
            set { postal = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Local.
        /// </summary>
        /// <param name="endereco">O endereço.</param>
        /// <param name="cidade">A cidade.</param>
        /// <param name="pais">O país.</param>
        /// <param name="postal">O código postal.</param>
        public Local(string endereco, string cidade, string pais, string postal)
        {
            Endereco = endereco;
            Cidade = cidade;
            Pais = pais;
            Postal = postal;
        }

        #endregion
    }
}
