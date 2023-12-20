/*
 * 
 * criacao da class e construtor da classe imovel em C#
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

using Caracteristicas;
using Gestores;
using Inquilinos;
using Locais;
using System.Collections;
using System.Numerics;

namespace Imoveis
{
    /// <summary>
    /// Classe para representar um imóvel
    /// </summary>
    public class Imovel : IImovel
    {
        #region Atributos

        private ArrayList imoveis = new ArrayList();
        private TipoImovel tipo;
        private Local local;
        private string condicao;
        private Caracteristica caracteristica;
        private bool disponivel;
        private Inquilino inquilino;
        private Gestor gestor;
        private const double valorPorMetroQuadrado = 530;
        private double preco;

        
 #endregion

    #region Propriedades

        public double ValorPorMetroQuadrado
        {
            get { return valorPorMetroQuadrado; }
        }

        public ArrayList Imoveis
        {
            get { return imoveis; }
            set { imoveis = value; }
        }
        public TipoImovel Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Local Local
        {
            get { return local; }
            set { local = value; }
        }
        public string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }
        public Caracteristica Caracteristica
        {
            get { return  caracteristica; }
            set {  caracteristica = value; }
        }

        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }
        public Inquilino Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }
        public Gestor Gestor
        {
            get { return gestor; }
            set { gestor = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        #endregion

        #region Metodos

        public double RetornaPrecoBasePorTipoImovel(TipoImovel tipoImovel)
        {
            switch (tipoImovel)
            {
                case TipoImovel.Apartamento:
                    return 10000;
                case TipoImovel.Vivenda:
                    return 20000;
                case TipoImovel.Terreno:
                    return 5000;
                default:
                    return 0;
            }
        }

        #endregion

        #region Construtor

        public Imovel(TipoImovel tipo, Local local, string condicao, Caracteristica caracteristica, bool disponivel, Inquilino inquilino, Gestor gestor, double valorPorMetroQuadrado)
        {
            if (string.IsNullOrEmpty(condicao))
            {
                throw new ArgumentException("A condição do imóvel não pode ser nula ou vazia.");
            }

            this.tipo = tipo;
            this.local = local;
            this.condicao = condicao;
            this.caracteristica = caracteristica;
            this.disponivel = disponivel;
            this.inquilino = inquilino;
            this.gestor = gestor;
            this.preco = RetornaPrecoBasePorTipoImovel(tipo);
        }

        #endregion
    }
}