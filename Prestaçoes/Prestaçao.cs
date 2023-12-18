using DataTempo;
using Inquilinos;

namespace Prestaçoes
{
    public class Prestaçao
    {
        #region Atributos
        private Data dataPagamento;
        private double valorPrestacao;
        private bool pago;
        private Inquilino inquilino;

        #endregion

        #region Propriedades

        public double ValorPrestacao
        {
            get { return valorPrestacao; }
            set { valorPrestacao = value; }
        }

        public bool Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        #endregion

        #region Metodos

        public long DiasDesdeUltimaPrestacao(DateTime diaPagamento)
        {
            TimeSpan diferenca = DateTime.Now - diaPagamento;
            return (long)diferenca.TotalDays;
        }
        public void MultaPrestacaoAtraso(DateTime diferenca)
        {
            long NumeroDias = DiasDesdeUltimaPrestacao(diferenca);
            if(NumeroDias > 30)
            {
                Pago = false;
                valorPrestacao += valorPrestacao * 0.1;
            }
        }
        public void PagarPrestacao(long NumeroDias)
        {
            if (Pago == false && NumeroDias > 30)
               {                 
                Pago = true;
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
        public Prestaçao( double valorPrestacao)
        {
            ValorPrestacao = valorPrestacao;
            Pago = false; // A prestação é considerada não paga inicialmente
        }

        #endregion
    }
}