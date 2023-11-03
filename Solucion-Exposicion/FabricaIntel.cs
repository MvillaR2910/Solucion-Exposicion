using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Exposicion
{
    // Paso 4: Implementa fábricas concretas para marcas de componentes (por ejemplo, Intel)
    public class FabricaIntel: FabricaComponentes
    {
        public override ICPU CrearCPU()
        {
            return new CPUIntel();
        }

        public override IRAM CrearRAM()
        {
            return new RAMIntel();
        }

        public override IGPU CrearGPU()
        {
            return new GPUIntel();
        }
    }
}
