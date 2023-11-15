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

using Caracterização;
using Clientes;
using Gestores;
using Locais;
using Senhorios;
using TiposImoveis;

namespace Imoveis
{
    /// <summary>
    /// Classe para representar um imóvel
    /// </summary>
    public class Imovel
    {
        #region Atributos

        private TipoImovel tipo;
        private Local local;
        private string condicao;
        private Caracteristica caracteristica;
        private bool estado;
        private Senhorio senhorio;
        private Cliente cliente;
        private Gestor gestor;


        
 #endregion

    #region Propriedades

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

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Senhorio Senhorio
        {
            get { return senhorio; }
            set { senhorio = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Gestor Gestor
        {
            get { return gestor; }
            set { gestor = value; }
        }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Imovel
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="endereco"></param>
        /// <param name="rendaMensal"></param>
        public Imovel(TipoImovel tipo, string endereco, Caracteristica caracteristica, double rendaMensal, Senhorio senhorio,Cliente cliente, Gestor gestor)
        {
            TipoImovel Tipo = tipo;
            Local Local = local;
            Condicao = condicao;
            Caracteristica = caracteristica;
            Estado = true;
            Senhorio = senhorio;
            Cliente = cliente;
            Gestor = gestor;
            /// Imóvel está disponível para aluguer inicialmente
        }

        #endregion
    }
}