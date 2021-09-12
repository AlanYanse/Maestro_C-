using System;

namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Comerciante cisco = new Comerciante();
            cisco.setEdad(33);
            cisco.setComision(300);
            cisco.setSalario(1000);

            Console.WriteLine("El sueldo de cisco es " + cisco.elPlus()); ;

            Repartidor chuck = new Repartidor();
            chuck.setEdad(33);
            chuck.setZona("3");
            chuck.setSalario(1000);

            Console.WriteLine("El sueldo de chuck es " + chuck.elPlus());
        }
    }
}
