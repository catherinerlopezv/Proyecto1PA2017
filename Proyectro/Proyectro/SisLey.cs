using System;
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

        public void initializeData()
        {
            Parlametario parlamentario = new Parlametario
            {
                NumGrupo = 1,
                InUsuario = "Parla001",
                Clave = "parla001",
                Nombre = "Parlamentario 001",
                CantAsesores = 1
            };

            Asesor asesor = new Asesor
            {
                InUsuario = "Ase001",
                Clave = "ase001",
                Nombre = "Asesor 001"
            };

            parlamentario.Asesores.Add(asesor);

            asesor = new Asesor
            {
                InUsuario = "Ase002",
                Clave = "ase002",
                Nombre = "Asesor 002"
            };

            parlamentario.Asesores.Add(asesor);

            this.Parlamentarios.Add(parlamentario);

            Ley ley = new Ley {
                NumeroDocumento = 1,
                Titulo = "Ley 001",
                Contenido = "Ley de primer orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 },
                CantReglamentos = 2
            };

            Reglamento reglamento = new Reglamento {
                NumeroDocumento = 1001,
                Titulo = "Reglamento 1001",
                Contenido = "Reglamento de primer orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 }
            };

            ley.Reglamentos.Add(reglamento);

            reglamento = new Reglamento
            {
                NumeroDocumento = 1002,
                Titulo = "Reglamento 1002",
                Contenido = "Reglamento de primer orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 }
            };

            ley.Reglamentos.Add(reglamento);

            this.Leyes.Add(ley);

            ley = new Ley
            {
                NumeroDocumento = 2,
                Titulo = "Ley 002",
                Contenido = "Ley de segundo orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 },
                CantReglamentos = 2
            };

            reglamento = new Reglamento
            {
                NumeroDocumento = 2001,
                Titulo = "Reglamento 2001",
                Contenido = "Reglamento de segundo orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 }
            };

            ley.Reglamentos.Add(reglamento);

            reglamento = new Reglamento
            {
                NumeroDocumento = 2002,
                Titulo = "Reglamento 2002",
                Contenido = "Reglamento de segundo orden",
                FechaCreacion = DateTime.Now,
                NumCopias = 5,
                CopiasDisponibles = 5,
                ColaCopias = { 1, 2, 3, 4, 5 }
            };

            ley.Reglamentos.Add(reglamento);

            this.Leyes.Add(ley);
        }

    }
}
