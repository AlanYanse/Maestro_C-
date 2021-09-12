using System;

namespace Metodos_Y_ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Verano mi_verano = new Verano();
            mi_verano.sensacion();

            Invierno mi_invierno = new Invierno();
            mi_invierno.sensacion();
        }
    }
}
