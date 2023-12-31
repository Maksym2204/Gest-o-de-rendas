namespace Recibos
{
    public class ReciboEmPapel : Recibo
    {
        public ReciboEmPapel(string nomeLocatario, string enderecoImovel, double valorPago, DateTime dataPagamento) : base(nomeLocatario, enderecoImovel, valorPago, dataPagamento)
        {
        }

        public override void EmitirRecibo()
        {
            Console.WriteLine("Recibo impresso");
            Console.WriteLine(this.ValorPago);
            Console.WriteLine(this.EnderecoImovel);
            Console.WriteLine(this.NomeLocatario);
            Console.WriteLine(this.DataPagamento);
        }
    }
}
