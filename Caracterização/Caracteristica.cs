namespace Caracterizaçao
{
    public class Caracteristica
    {
        #region Campos

        private int numeroQuartos;
        private int numeroWC;
        private bool possuiGaragem;
        private double areaTotal;
        private bool possuiJardim;
        private bool mobiliado;

        #endregion

        #region Propriedades

        public int NumeroQuartos
        {
            get { return numeroQuartos; }
            set { numeroQuartos = value; }
        }

        public int NumeroWC
        {
            get { return numeroWC; }
            set { numeroWC = value; }
        }

        public bool PossuiGaragem
        {
            get { return possuiGaragem; }
            set { possuiGaragem = value; }
        }

        public double AreaTotal
        {
            get { return areaTotal; }
            set { areaTotal = value; }
        }

        public bool PossuiJardim
        {
            get { return possuiJardim; }
            set { possuiJardim = value; }
        }

        public bool Mobiliado
        {
            get { return mobiliado; }
            set { mobiliado = value; }
        }

        #endregion

        #region Construtores

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

