using System.Collections;

namespace Proyectro
{
    class SisLey
    {

        private static SisLey sistema;
        private ArrayList parlamentarios;
        private ArrayList leyes;

        public static SisLey getInstance()
        {
            if (sistema == null)
            {
                sistema = new SisLey();
            }
            return sistema;
        }

        public ArrayList Parlamentarios
        {
            get
            {
                if (parlamentarios == null)
                {
                    parlamentarios = new ArrayList();
                }
                return parlamentarios;
            }
            set
            {
                parlamentarios = value;
            }
        }

        public ArrayList Leyes
        {
            get
            {
                if (leyes == null)
                {
                    leyes = new ArrayList();
                }
                return leyes;
            }
            set
            {
                leyes = value;
            }
        }

    }
}
