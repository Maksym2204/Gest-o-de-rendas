namespace GestaoImoveis
{
    // Classe para representar um imóvel
    public class Imovel
    {
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public double RendaMensal { get; set; }
        public bool Estado { get; set; }

        // Construtor da classe Imovel
        public Imovel(string tipo, string endereco, double rendaMensal)
        {
            Tipo = tipo;
            Endereco = endereco;
            RendaMensal = rendaMensal;
            Estado = true; // Imóvel está disponível para aluguer inicialmente
        }
    }
}