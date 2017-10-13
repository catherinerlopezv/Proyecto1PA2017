using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Prestamo
    {
        private int numeroDocumento;
        private int numCopia;
        private string usuario;
        private int numGrupo;
        private string estado;
        private int numeroDocumentoMaestro;

        public int NumeroDocumento
        {
            get
            {
                return numeroDocumento;
            }
            set
            {
                numeroDocumento = value;
            }
        }

        public int NumCopia
        {
            get
            {
                return numCopia;
            }
            set
            {
                numCopia = value;
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

        public int NumeroDocumentoMaestro
        {
            get
            {
                return numeroDocumentoMaestro;
            }
            set
            {
                numeroDocumentoMaestro = value;
            }
        }
    }
}
