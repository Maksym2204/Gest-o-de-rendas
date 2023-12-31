/*Class : Caracteristicas
 * Mario Macedo
 * Maksym Yavorenko
 * a25664@alunos.ipca.pt
 * a25989@alunos.ipca.pt
 * 13-11-2023
 * 
 * */

namespace Caracteristicas
{
    /// <summary>
    /// Classe que representa as características de um imóvel.
    /// </summary>
    public class Caracteristica
    {
        #region Campos

        private int numeroQuartos;
        private int numeroWC;
        private bool possuiGaragem;
        private double areaTotal;
        private bool possuiJardim;
        private bool mobiliado;
        private int metrosQuadrados;

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define a quantidade de metros quadrados.
        /// </summary>
        public int MetrosQuadrados
        {
            get { return metrosQuadrados; }
            set { metrosQuadrados = value; }
        }

        /// <summary>
        /// Obtém ou define o número de quartos.
        /// </summary>
        public int NumeroQuartos
        {
            get { return numeroQuartos; }
            set { numeroQuartos = value; }
        }

        /// <summary>
        /// Obtém ou define o número de banheiros.
        /// </summary>
        public int NumeroWC
        {
            get { return numeroWC; }
            set { numeroWC = value; }
        }

        /// <summary>
        /// Obtém ou define se o imóvel possui garagem.
        /// </summary>
        public bool PossuiGaragem
        {
            get { return possuiGaragem; }
            set { possuiGaragem = value; }
        }

        /// <summary>
        /// Obtém ou define a área total do imóvel.
        /// </summary>
        public double AreaTotal
        {
            get { return areaTotal; }
            set { areaTotal = value; }
        }

        /// <summary>
        /// Obtém ou define se o imóvel possui jardim.
        /// </summary>
        public bool PossuiJardim
        {
            get { return possuiJardim; }
            set { possuiJardim = value; }
        }

        /// <summary>
        /// Obtém ou define se o imóvel está mobiliado.
        /// </summary>
        public bool Mobiliado
        {
            get { return mobiliado; }
            set { mobiliado = value; }
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor da classe Caracteristica.
        /// </summary>
        /// <param name="numeroQuartos">O número de quartos.</param>
        /// <param name="numeroWC">O número de banheiros.</param>
        /// <param name="possuiGaragem">Indica se o imóvel possui garagem.</param>
        /// <param name="areaTotal">A área total do imóvel.</param>
        /// <param name="possuiJardim">Indica se o imóvel possui jardim.</param>
        /// <param name="mobiliado">Indica se o imóvel está mobiliado.</param>
        public Caracteristica(int numeroQuartos, int numeroWC, bool possuiGaragem, double areaTotal, bool possuiJardim, bool mobiliado)
        {
            NumeroQuartos = numeroQuartos;
            NumeroWC = numeroWC;
            PossuiGaragem = possuiGaragem;
            AreaTotal = areaTotal;
            PossuiJardim = possuiJardim;
            Mobiliado = mobiliado;
        }

        #endregion
    }
}
