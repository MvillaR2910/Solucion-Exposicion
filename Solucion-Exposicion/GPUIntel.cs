using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Exposicion
{
    public class GPUIntel: IGPU
    {
        public string Descripcion()
        {
            return "GPU Intel integrada";
        }

        public string Compatibilidad()
        {
            return "Compatibilidad con placas base Intel";
        }
    }
}
