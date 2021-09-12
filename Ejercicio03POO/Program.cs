using System;

namespace Ejercicio03POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar nombre del alumno");

            Alumno alumno1 = new Alumno(Console.ReadLine());
                             
                
            Console.WriteLine(alumno1.getNombre());
            Console.WriteLine(alumno1.calcularPromPrimerasNotas(10, 8));
            Console.WriteLine(alumno1.calcularPromSegundasNotas(7, 6));
            Console.WriteLine(alumno1.calcularPromTotal());
        }
    }
}
