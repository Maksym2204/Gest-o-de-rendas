namespace Recibos
{
    public class ReciboOnline : Recibo
    {
        public ReciboOnline(string nomeLocatario, string enderecoImovel, double valorPago, DateTime dataPagamento) : base(nomeLocatario, enderecoImovel, valorPago, dataPagamento)
        {
        }

        public override void EmitirRecibo()
        {
            //enviar recibo por email
        }
    }
}
