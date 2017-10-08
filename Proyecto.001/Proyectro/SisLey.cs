using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    public class SisLey
    {
        private ArrayList parlamentarios;
        private static SisLey sistema;
        private ArrayList asesores;

        public static SisLey getInstance()
        {
            if (sistema == null)
            {
                sistema = new SisLey();
            }
            return sistema;
        }

        public ArrayList GetParlamentarios()
        {
            if (parlamentarios == null)
            {
                parlamentarios = new ArrayList();
            }

            return parlamentarios;
        }

        public ArrayList GetAsesores()
        {
            if (asesores == null)
            {
                asesores = new ArrayList();
            }

            return asesores;
        }


    }
}
