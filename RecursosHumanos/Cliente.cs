namespace RecursosHumanos
{
    public class Cliente : Pessoa
    {
        #region Atributos

        private double entrada;
        #endregion

        #region Propriedades

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
        public Cliente(string nome, string nif, string telefone, string email, double entrada) : base(nome, nif, telefone, email)
        {
  
            Entrada = 20000;
        }

        #endregion
    }
}