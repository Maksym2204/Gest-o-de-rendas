using System.Collections;
using Imoveis;
using Pagamentos;

namespace RecursosHumanos
{
    public class Inquilino : Pessoa, ISaldo
    {
        #region Atributos
        private ArrayList inquilinos = new ArrayList();
        private string endereco;
        private Prestacao prestacao;
        private TipoImovel tipoImovel;
        private double saldo;
        private int numeroMensalidades;
        #endregion

        #region Propriedades

        public int NumeroMensalidades
        {
            get { return numeroMensalidades; }
            set { numeroMensalidades = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public TipoImovel TipoImovel
        {
            get { return tipoImovel; }
            set { tipoImovel = value; }
        }

        public ArrayList Inquilinos
        {
            get { return inquilinos; }
            set { inquilinos = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public Prestacao Prestacao
        {
            get { return prestacao; }
            set { prestacao = value; }
        }

        #endregion

        #region Metodos
        public double RetirarSaldo(double valor)
        {
            return Saldo -= valor;
        }

        public double DepositarSaldo(double valor)
        {
            return Saldo += valor;
        }


        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Inquilinos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="endereco"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        /// <param name="dataInicioContrato"></param>
        public Inquilino(string nome, string endereco,string nif, string telefone, string email, Prestacao prestacao, int numeroMensalidades) : base(nome,nif, telefone, email)
        {
            this.numeroMensalidades = numeroMensalidades;
            this.prestacao = prestacao;
        }

        #endregion
    }
}