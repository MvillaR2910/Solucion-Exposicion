using System;
using Solucion_Exposicion;

class Program
{
    static void Main(string[] args)
    {
        // Paso 5: Crea una instancia de una fábrica concreta (por ejemplo, FabricaIntel)
        FabricaComponentes fabrica = new FabricaIntel();

        // Crea componentes de CPU, RAM y GPU y muestra sus descripciones y compatibilidad
        ICPU cpu = fabrica.CrearCPU();
        IRAM ram = fabrica.CrearRAM();
        IGPU gpu = fabrica.CrearGPU();

        Console.WriteLine("Componentes de Intel:");
        Console.WriteLine("CPU: " + cpu.Descripcion() + ", " + cpu.Compatibilidad());
        Console.WriteLine("RAM: " + ram.Descripcion() + ", " + ram.Compatibilidad());
        Console.WriteLine("GPU: " + gpu.Descripcion() + ", " + gpu.Compatibilidad());
    }
}
