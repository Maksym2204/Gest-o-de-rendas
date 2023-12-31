/* Class: Documentos
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace Documentos
{
    /// <summary>
    /// Representa um documento.
    /// </summary>
    public class Documento
    {
        #region Atributos

        private string tipoDocumento;
        private string numeroDocumento;
        private DateTime dataEmissao;
        private bool valido;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o tipo do documento.
        /// </summary>
        public string TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        /// <summary>
        /// Obtém ou define o número do documento.
        /// </summary>
        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        /// <summary>
        /// Obtém ou define a data de emissão do documento.
        /// </summary>
        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        /// <summary>
        /// Obtém ou define se o documento é válido.
        /// </summary>
        public bool Valido
        {
            get { return valido; }
            set { valido = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Documento.
        /// </summary>
        /// <param name="tipoDocumento">O tipo do documento.</param>
        /// <param name="numeroDocumento">O número do documento.</param>
        /// <param name="dataEmissao">A data de emissão do documento.</param>
        public Documento(string tipoDocumento, string numeroDocumento, DateTime dataEmissao)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            DataEmissao = dataEmissao;
            Valido = true; // O documento é considerado válido inicialmente
        }

        #endregion
    }
}
