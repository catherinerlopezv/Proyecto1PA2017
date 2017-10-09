using System.Collections;

namespace Proyectro
{
    class SisLey
    {

        private static SisLey sistema;
        private ArrayList parlamentarios;
        private ArrayList leyes;
        private Parlametario usuarioParlamentario;
        private Asesor usuarioAsesor;
        private ArrayList prestamoLeyes;
        private ArrayList prestamoReglamentos;

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

        public ArrayList PrestamoLeyes
        {
            get
            {
                if (prestamoLeyes == null)
                {
                    prestamoLeyes = new ArrayList();
                }
                return prestamoLeyes;
            }
            set
            {
                prestamoLeyes = value;
            }
        }

        public ArrayList PrestamoReglamentos
        {
            get
            {
                if (prestamoReglamentos == null)
                {
                    prestamoReglamentos = new ArrayList();
                }
                return prestamoReglamentos;
            }
            set
            {
                prestamoReglamentos = value;
            }
        }

        public Parlametario UsuarioParlamentario
        {
            get
            {
                return usuarioParlamentario;
            }
            set
            {
                usuarioParlamentario = value;
            }
        }

        public Asesor UsuarioAsesor
        {
            get
            {
                return usuarioAsesor;
            }
            set
            {
                usuarioAsesor = value;
            }
        }

    }
}
