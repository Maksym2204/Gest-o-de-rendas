/* Class: Servicos
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
namespace Servicos
{
    /// <summary>
    /// Classe que representa um serviço a ser realizado em um imóvel.
    /// </summary>
    public class Servico
    {
        #region Atributos

        private string requisitante;
        private string imovel;
        private TipoServico tipoServico;
        private double valorServico;
        private DateTime dataExecucao;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o endereço do imóvel associado ao serviço.
        /// </summary>
        public string Imovel
        {
            get { return imovel; }
            set { imovel = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do requisitante do serviço.
        /// </summary>
        public string Requisitante
        {
            get { return requisitante; }
            set { requisitante = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo de serviço a ser realizado.
        /// </summary>
        public TipoServico TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        /// <summary>
        /// Obtém ou define o valor associado ao serviço.
        /// </summary>
        public double ValorServico
        {
            get { return valorServico; }
            set { valorServico = value; }
        }

        /// <summary>
        /// Obtém ou define a data de execução do serviço.
        /// </summary>
        public DateTime DataExecucao
        {
            get { return dataExecucao; }
            set { dataExecucao = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Retorna o preço base associado a um determinado tipo de serviço.
        /// </summary>
        /// <param name="tipoServico">O tipo de serviço.</param>
        /// <returns>O preço base do serviço.</returns>
        public double RetornaPrecoBasePorTipoServico(TipoServico tipoServico)
        {
            switch (tipoServico)
            {
                case TipoServico.Limpeza:
                    return 40;
                case TipoServico.Manutencao:
                    return 50;
                case TipoServico.Pintura:
                    return 30;
                case TipoServico.Eletricidade:
                    return 35;
                case TipoServico.Canalizacao:
                    return 45;
                case TipoServico.Outros:
                    return 50;
                default:
                    return 0;
            }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Servico.
        /// </summary>
        /// <param name="requisitante">O nome do requisitante do serviço.</param>
        /// <param name="imovel">O endereço do imóvel associado ao serviço.</param>
        /// <param name="tipoServico">O tipo de serviço a ser realizado.</param>
        /// <param name="dataExecucao">A data de execução do serviço.</param>
        public Servico(string requisitante, string imovel, TipoServico tipoServico, DateTime dataExecucao)
        {
            this.requisitante = requisitante;
            this.imovel = imovel;
            this.tipoServico = tipoServico;
            this.valorServico = RetornaPrecoBasePorTipoServico(tipoServico);
            this.dataExecucao = dataExecucao;
        }

        #endregion
    }
}
