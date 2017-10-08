using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Parlametario: Usuario
    {
        private int cantAsesores;
        private ArrayList asesores;
        private int numGrupo;

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

        public int CantAsesores { get => cantAsesores; set => cantAsesores = value; }
       public ArrayList Asesores { get => asesores; set => asesores = value; }
    }
}
