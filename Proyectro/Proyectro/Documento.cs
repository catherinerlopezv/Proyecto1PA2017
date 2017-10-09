using System;
using System.Collections;

namespace Proyectro
{
    class Documento
    {
        private int numeroDocumento;
        private string titulo;
        private DateTime fechaCreacion;
        private string contenido;
        private int numCopias;
        private int copiasDisponibles;
        private ArrayList colaCopias;

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

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }


        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value;
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

        public int CopiasDisponibles
        {
            get
            {
                return copiasDisponibles;
            }
            set
            {
                copiasDisponibles = value;
            }
            
        }

        public ArrayList ColaCopias
        {
            get
            {
                if (colaCopias == null)
                {
                    colaCopias = new ArrayList();
                }
                return colaCopias;
            }
            set
            {
                colaCopias = value;
            }
        }
    }
}
