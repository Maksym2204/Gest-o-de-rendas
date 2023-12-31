/*Class: Contratos
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

using Imoveis;
using RecursosHumanos;

namespace Contratos
{
    /// <summary>
    /// Classe para representar um contrato de aluguer
    /// </summary>
    public class Contrato
    {
        #region Atributos

        private Inquilino inquilino;
        private Imovel imovel;
        private DateTime dataInicio;
        private DateTime dataFim;
        private int numeroMensalidades;
        private double valorMensalidade;
        private double entrada;

        #endregion

        #region Propriedades

        public double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }   
        /// <summary>
        /// Obtém ou define o imóvel associado ao contrato.
        /// </summary>
        public Imovel Imovel
        {
            get { return imovel; }
            set { imovel = value; }
        }

        /// <summary>
        /// Obtém ou define a data de início do contrato.
        /// </summary>
        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        /// <summary>
        /// Obtém ou define a data de fim do contrato.
        /// </summary>
        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Inquilino Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }

        /// <summary>
        /// Obtém ou define o valor mensal do contrato.
        /// </summary>
        public int NumeroMensalidades
        {
            get { return numeroMensalidades; }
            set { numeroMensalidades = value; }
        }

        public double ValorMensalidade
        {
            get { return valorMensalidade; }
            set { valorMensalidade = value; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="gestor"></param>
        /// <param name="imovel"></param>
        /// <param name="entrada"></param>
        /// <param name="numeroMensalidades"></param>
        /// <param name="valorMensalidade"></param>
        public Contrato(Cliente cliente, Gestor gestor, Imovel imovel, double entrada, int numeroMensalidades, double valorMensalidade)
        {
            cliente.RetirarSaldo(entrada);

            Inquilino inquilino = new Inquilino(cliente.Nome, imovel.Local.Endereco, cliente.NIF, cliente.Telefone, cliente.Email);

            imovel.AdicionarInquilino(inquilino);

            this.inquilino = inquilino;
            this.imovel = imovel;
            this.dataInicio = DateTime.Now;
            this.dataFim = DateTime.Now.AddMonths(numeroMensalidades);
            this.entrada = entrada;
            this.numeroMensalidades = numeroMensalidades;
            this.valorMensalidade = valorMensalidade;
        }

        #endregion
    }
}