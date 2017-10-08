using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Prestamo
    {
        private int numDocumento;
        private int numCopias;
        private string usuario;
        private int numGrupo;
        private string estado;

        public int NumDocumento
        {
            get
            {
                return numDocumento;
            }
            set
            {
                numDocumento = value;
            }
        }

        public int NumCopias
        {
            get
            {
                return numCopias;
            }
            set
            {
                numCopias = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

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

        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
    }
}
