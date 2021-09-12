using System;
using System.Collections;

namespace ClaseArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cosas = new ArrayList(); // Instanciando un ArrayList

            // Agregando elementos al ArrayList

            cosas.Add("manzana");
            cosas.Add("silla");
            cosas.Add("perro");
            cosas.Add(15);
            cosas.Add(3.1416);

            cosas.Insert(4, "bitcoin"); // Insertando elemento en una ubicación específica del ArrayList

            Console.WriteLine(cosas[0]); // Imprimiendo un elemento

            Console.WriteLine("-------------------");


            // Imprimiendo todos los elementos del ArrayList

            foreach (var cosillas in cosas)
            {
                Console.WriteLine(cosillas);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine(cosas.Count); // Mostrando cuantos elementos tiene el ArrayList
        }
    }
}
