using System;

namespace GestaoImoveis
{
    // Classe para representar um contrato de aluguel
    class Contrato
    {
        public Imovel Imovel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Inquilino { get; set; }
        public double ValorMensal { get; set; }

        // Construtor da classe Contrato
        public Contrato(Imovel imovel, DateTime dataInicio, DateTime dataFim, string inquilino, double valorMensal)
        {
            Imovel = imovel;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Inquilino = inquilino;
            ValorMensal = valorMensal;
        }
    }
}