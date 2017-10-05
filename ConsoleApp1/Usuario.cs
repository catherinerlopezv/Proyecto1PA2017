using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Usuario
    {

        private int numGrupo;
        private string inUsuario;
        private string clave;
        private string nombre;
        // private int asesores; list <Asesor> asesores; list <parlamentario> parlamentario;

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

        public string InUsuario
        {
            get
            {
                return inUsuario;
            }
            set
            {
                inUsuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

    }
}
