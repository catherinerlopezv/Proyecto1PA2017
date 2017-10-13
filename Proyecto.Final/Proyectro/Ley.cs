using System.Collections;

namespace Proyectro
{
    class Ley: Documento
    {
        private int cantReglamentos;
        private ArrayList reglamentos;

        public int CantReglamentos
        {
            get
            {
                return cantReglamentos;
            }
            set
            {
                cantReglamentos = value;
            }
        }

        public ArrayList Reglamentos
        {
            get
            {
                if (reglamentos == null)
                {
                    reglamentos = new ArrayList();
                }
                return reglamentos;
            }
            set
            {
                reglamentos = value;
            }
        }
    }
}
