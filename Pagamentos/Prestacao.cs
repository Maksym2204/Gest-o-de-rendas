using DataTempo;
using RecursosHumanos;

namespace Pagamentos
{
    public class Prestacao
    {
        #region Atributos

        private Data dataPagamento;
        private double valorPrestacao;

        #endregion

        #region Propriedades

        public double ValorPrestacao
        {
            get { return valorPrestacao; }
            set { valorPrestacao = value; }
        }

        #endregion

        #region Metodos

        public long DiasDesdeUltimaPrestacao(DateTime diaPagamento)
        {
            TimeSpan diferenca = DateTime.Now - diaPagamento;
            return (long)diferenca.TotalDays;
        }
        //public void MultaPrestacaoAtraso(DateTime diferenca)
        //{
        //    long NumeroDias = DiasDesdeUltimaPrestacao(diferenca);
        //    if(NumeroDias > 30)
        //    {
        //        Pago = false;
        //        valorPrestacao += valorPrestacao * 0.1;
        //    }
        //}

        public void PagarPrestacao(DateTime diferenca, Inquilino inquilino)
        {
            //ValorDaPrestacao(precoBase, );
            long NumeroDias = DiasDesdeUltimaPrestacao(diferenca);
            if ( NumeroDias > 30)
            {
                inquilino.RetirarSaldo(valorPrestacao);
            }
        }
        public void ValorDaPrestacao(double precoBase, int numeroMensalidades)
        {
            valorPrestacao = precoBase / numeroMensalidades;

        }

        #endregion
        #region Construtor

        /// <summary>
        /// Construtor da classe Prestacoes
        /// </summary>
        /// <param name="dataPagamento"></param>
        /// <param name="valorPrestacao"></param>
        public Prestacao( double valorPrestacao)
        {
            ValorPrestacao = valorPrestacao;
        }

        #endregion
    }
}