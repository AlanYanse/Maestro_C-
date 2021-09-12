using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona boyi = new Empleado();
            boyi.setNombreYapellido("Angel", "Corradi");

            Persona cisco = new Cliente();
            cisco.setNombreYapellido("Francisco", "Loberse");

            Console.WriteLine("El nombre del empleado es " + boyi.getNombreYapellido());
            Console.WriteLine("El nombre del cliente es " + cisco.getNombreYapellido());
            
        }
    }
}
