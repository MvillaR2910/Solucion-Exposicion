using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Exposicion
{
    public class CPUIntel: ICPU
    {
        public string Descripcion()
        {
            return "CPU Intel de última generación";
        }

        public string Compatibilidad()
        {
            return "Compatibilidad con placas base Intel";
        }
    }
}
