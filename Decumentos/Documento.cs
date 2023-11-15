namespace Documentos
{
    public class Documento
    {
        #region Atributos

        private string tipoDocumento;
        private string numeroDocumento;
        private DateTime dataEmissao;
        private bool valido;

        #endregion

        #region Propriedades

        public string TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        public bool Valido
        {
            get { return valido; }
            set { valido = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Documentos
        /// </summary>
        /// <param name="tipoDocumento"></param>
        /// <param name="numeroDocumento"></param>
        /// <param name="dataEmissao"></param>
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