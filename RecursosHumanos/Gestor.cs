using Despesas;
using Recibos;
using Servicos;

namespace RecursosHumanos
{
    public class Gestor : Pessoa
    {
        #region Atributos

        private string cargo;
        private Despesa despesa;
        private Recibo recibo;
        private Servico servico;


        #endregion

        #region Propriedades

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
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
        public Servico Servico
        {
            get { return servico; }
            set { servico = value; }
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
        public Gestor(string nome,string nif, string cargo, string telefone, string email, Despesa despesa, Recibo recibo, Servico Servico) : base(nome, nif, telefone, email)
        {
            this.cargo = cargo;
            this.despesa = despesa;
            this.recibo = recibo;
            this.servico = servico;
        }

        #endregion
    }
}