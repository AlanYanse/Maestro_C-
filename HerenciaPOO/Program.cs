using System;

namespace HerenciaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno cisco = new Alumno();

            cisco.setNombre("Francisco");

            cisco.setApellido("Loberse");

            cisco.setAprobado(false);

            Console.WriteLine("Alumno " + cisco.getNombreApellido());
            Console.WriteLine("Aprobado " + cisco.getAprobado());

        }
    }
}
