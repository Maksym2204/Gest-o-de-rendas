namespace TiposImoveis
{
    public class TipoImovel
    {
        #region Atributos

        private string nome;
        private string descricao;

        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe TipoImovel
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        public TipoImovel(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        #endregion
    }
}