using System.Collections;

namespace Proyectro
{
    class Parlametario: Usuario
    {
        private int cantAsesores;
        private int numGrupo;
        private ArrayList asesores;

        public int NumGrupo
        {
            get
            {
                return numGrupo;
            }
            set
            {
                numGrupo = value;
            }
        }

        public int CantAsesores
        {
            get
            {
                return cantAsesores;
            }
            set
            {
                cantAsesores = value;
            }
        }

        public ArrayList Asesores
        {
            get
            {
                if (asesores == null)
                {
                    asesores = new ArrayList();
                }
                return asesores;
            }
            set
            {
                asesores = value;
            }
        }
        
    }
}
