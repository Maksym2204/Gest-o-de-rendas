/*
 * 
 * criacao da class e construtor da classe imovel 
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */
using Caracteristicas;
using Locais;
using RecursosHumanos;

namespace Imoveis
{
    /// <summary>
    /// Classe para representar um imóvel.
    /// </summary>
    public class Imovel : IImovel
    {
        #region Atributos

        private List<Inquilino> inquilinos = new List<Inquilino>();
        private TipoImovel tipo;
        private Local local;
        private TipoCondicao condicao;
        private Caracteristica caracteristica;
        private bool disponivel;
        private Gestor gestor;
        private const double valorPorMetroQuadrado = 530;
        private double preco;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o valor por metro quadrado.
        /// </summary>
        public double ValorPorMetroQuadrado
        {
            get { return valorPorMetroQuadrado; }
        }
        /// <summary>
        /// Obtém ou define o tipo do imóvel.
        /// </summary>
        public TipoImovel Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtém ou define o local do imóvel.
        /// </summary>
        public Local Local
        {
            get { return local; }
            set { local = value; }
        }

        /// <summary>
        /// Obtém ou define a condição do imóvel.
        /// </summary>
        public TipoCondicao Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }

        /// <summary>
        /// Obtém ou define as características do imóvel.
        /// </summary>
        public Caracteristica Caracteristica
        {
            get { return caracteristica; }
            set { caracteristica = value; }
        }

        /// <summary>
        /// Obtém ou define a disponibilidade do imóvel.
        /// </summary>
        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }

        /// <summary>
        /// Obtém ou define o gestor do imóvel.
        /// </summary>
        public Gestor Gestor
        {
            get { return gestor; }
            set { gestor = value; }
        }

        /// <summary>
        /// Obtém ou define o preço do imóvel.
        /// </summary>
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Retorna o preço base com base no tipo de imóvel.
        /// </summary>
        /// <param name="tipoImovel">O tipo do imóvel.</param>
        /// <returns>O preço base.</returns>
        public double RetornaPrecoBasePorTipoImovel(TipoImovel tipoImovel)
        {
            switch (tipoImovel)
            {
                case TipoImovel.Apartamento:
                    return 120000;
                case TipoImovel.Vivenda:
                    return 160000;
                case TipoImovel.Terreno:
                    return 90000;
                default:
                    return 0;
            }
        }

        #endregion

        #region Métodos
        public void AdicionarInquilino(Inquilino inquilino)
        {
            if (disponivel)
            {
                inquilinos.Add(inquilino);
            }
            else
            {
                throw new Exception("O imovel nao esta disponivel para arrendar");
            }
        }

        public void RemoverInquilino(string nif)
        {
            if (!string.IsNullOrEmpty(nif))
            {
                if (ExisteInquilino(nif))
                {
                    inquilinos.Remove(RetornaInquilino(nif));
                }
                else
                {
                    throw new ArgumentException("O inquilino nao existe neste imovel");
                }
            }
        }

        public bool ExisteInquilino(string nif)
        {
            return inquilinos.Exists(i => i.NIF == nif);
        }

        public List<Inquilino> RetornaInquilinos()
        {
            return inquilinos;
        }

        public Inquilino RetornaInquilino(string nif)
        {
            if (ExisteInquilino(nif))
            {
                return inquilinos.First(i => i.NIF == nif);
            }
            else
            {
                throw new ArgumentException("O inquilino nao existe neste imovel");
            }
        }   

        #endregion
        #region Construtor

        /// <summary>
        /// Construtor da class Imovel com inquilino
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="local"></param>
        /// <param name="condicao"></param>
        /// <param name="caracteristica"></param>
        /// <param name="disponivel"></param>
        /// <param name="gestor"></param>
        /// <param name="valorPorMetroQuadrado"></param>
        /// <exception cref="ArgumentException"></exception>
        public Imovel(TipoImovel tipo, Local local, TipoCondicao condicao, bool disponivel, List<Inquilino> inquilinos, Gestor gestor)
        {
            if (inquilinos == null || !inquilinos.Any())
            {
                throw new ArgumentException("Inquilinos nao podem ser nulo ou vazio");
            }

            this.tipo = tipo;
            this.local = local;
            this.condicao = condicao;
            this.disponivel = disponivel;
            this.gestor = gestor;
            this.preco = RetornaPrecoBasePorTipoImovel(tipo);
            this.inquilinos = inquilinos;
        }
        /// <summary>
        /// Construtor da class Imovel sem inqiulinos
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="local"></param>
        /// <param name="condicao"></param>
        /// <param name="caracteristica"></param>
        /// <param name="disponivel"></param>
        /// <param name="inquilino"></param>
        /// <param name="gestor"></param>
        /// <param name="valorPorMetroQuadrado"></param>
        /// <param name="preco"></param>
        /// <exception cref="ArgumentException"></exception>
        public Imovel(TipoImovel tipo, Local local, TipoCondicao condicao, Gestor gestor)
        {

            this.tipo = tipo;
            this.local = local;
            this.condicao = condicao;
            this.disponivel = true;// Como nao existem inquilinos o imovel esta disponivel
            this.gestor = gestor;
            this.preco = RetornaPrecoBasePorTipoImovel(tipo);
        }

        #endregion
    }
}
