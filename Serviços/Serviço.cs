namespace Serviços
{
    public class Serviço
    {
        #region Atributos

        private string tipoServico;
        private double valorServico;
        private DateTime dataExecucao;
        private bool concluido;

        #endregion

        #region Propriedades

        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        public double ValorServico
        {
            get { return valorServico; }
            set { valorServico = value; }
        }

        public DateTime DataExecucao
        {
            get { return dataExecucao; }
            set { dataExecucao = value; }
        }

        public bool Concluido
        {
            get { return concluido; }
            set { concluido = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Servicos
        /// </summary>
        /// <param name="tipoServico"></param>
        /// <param name="valorServico"></param>
        /// <param name="dataExecucao"></param>
        public Serviço(string tipoServico, double valorServico, DateTime dataExecucao)
        {
            TipoServico = tipoServico;
            ValorServico = valorServico;
            DataExecucao = dataExecucao;
            Concluido = false; // O serviço é considerado não concluído inicialmente
        }

        #endregion
    }
}