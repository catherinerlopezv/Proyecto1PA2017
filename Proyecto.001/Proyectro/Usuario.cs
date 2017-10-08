using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Usuario
    {
        
        private string inUsuario;
        private string clave;
        private string nombre;
        

        

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
