using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Exposicion
{
    public class RAMIntel: IRAM
    {
        public string Descripcion()
        {
            return "RAM Intel de alto rendimiento";
        }

        public string Compatibilidad()
        {
            return "Compatibilidad con placas base Intel";
        }
    }
}
