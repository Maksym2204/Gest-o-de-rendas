using Prestaçoes;
using Serviços;
using System.Collections;
using TiposImoveis;

namespace Inquilinos
{
    public class Inquilino
    {
        #region Atributos
        private ArrayList inquilinos = new ArrayList();
        private string nome;
        private string endereco;
        private string telefone;
        private string email;
        private DateTime dataInicioContrato;
        private Prestaçao prestaçao;
        private Serviço serviço;
        private TipoImovel tipoImovel;

        #endregion

        #region Propriedades
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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DataInicioContrato
        {
            get { return dataInicioContrato; }
            set { dataInicioContrato = value; }
        }
        public Prestaçao Prestaçao
        {
            get { return prestaçao; }
            set { prestaçao = value; }
        }
        public Serviço Serviço
        {
            get { return serviço; }
            set { serviço = value; }
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
        public Inquilino(string nome, string endereco, string telefone, string email, DateTime dataInicioContrato, Prestaçao prestaça, Serviço serviço)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            DataInicioContrato = dataInicioContrato;
            Prestaçao = prestaça;
            Serviço = serviço;
        }

        #endregion
    }
}