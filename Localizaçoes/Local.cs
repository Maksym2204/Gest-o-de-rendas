namespace Locais
{
    public class Local
    {
        #region Atributos

        private string endereco;
        private string cidade;
        private string estado;
        private string pais;
        private string postal;

        #endregion

        #region Propriedades

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Postal
        {
            get { return postal; }
            set { postal = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Local
        /// </summary>
        /// <param name="endereco"></param>
        /// <param name="cidade"></param>
        /// <param name="estado"></param>
        /// <param name="pais"></param>
        /// <param name="cep"></param>
        public Local(string endereco, string cidade, string estado, string pais, string postal)
        {
            Endereco = endereco;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Postal = postal;
        }

        #endregion
    }
}