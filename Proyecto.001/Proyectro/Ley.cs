using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectro
{
    class Ley: Documento
    {
        List<Reglamento> reglamentos;

        public List<Reglamento>Reglamentos
        {
            get
            {
                return reglamentos;
            }
            set
            {
                reglamentos = value;
            }
        }
    }
}
