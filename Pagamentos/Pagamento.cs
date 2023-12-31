namespace Pagamentos
{
    public class Pagamento
    {
        private double valor;
        private DateTime dataPagamento;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        public Pagamento(double valor, DateTime dataPagamento)
        {
            Valor = valor;
            DataPagamento = dataPagamento;
        }
    }
}
