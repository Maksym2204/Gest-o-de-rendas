namespace DataTempo
{
    public class Data
    {
        DateTime diaPagamento;

        public DateTime DiaPagamento
        {
            get => diaPagamento;
            set => diaPagamento = value;
        }

        public string DiaDaSemana()
        {
            return diaPagamento.DayOfWeek.ToString();
        }

        public long DiaDoMes()
        {
            return (long)diaPagamento.Day;
        }

    }
}
