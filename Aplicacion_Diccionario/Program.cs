using System;
using System.Collections.Generic;

namespace Aplicacion_Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 3;
            
            Dictionary<int, string> diccionario_pokemones = new Dictionary<int, string>();

            diccionario_pokemones.Add(1, "bulbasaur");
            diccionario_pokemones.Add(2, "ivysaur");
            diccionario_pokemones.Add(3, "venusaur");
            diccionario_pokemones.Add(4, "charmander");
            diccionario_pokemones.Add(5, "charmeleon");
            diccionario_pokemones.Add(6, "charizard");
            diccionario_pokemones[7] = "Squirtle";

            Console.WriteLine(diccionario_pokemones.Count);

            Console.WriteLine("Vamos a eliminar a ivysaur");

            diccionario_pokemones.Remove(2);

            Console.WriteLine("===============================");

            Console.WriteLine(diccionario_pokemones.Count);

            foreach (string valores in diccionario_pokemones.Values)
            {
                Console.WriteLine(valores);
            }

            Console.WriteLine("===============================");

            foreach (int clave in diccionario_pokemones.Keys)
            {
                Console.WriteLine(clave);
            }

            Console.WriteLine("===============================");

            if (diccionario_pokemones.ContainsKey(indice))
            {
                Console.WriteLine("existe y se llama " + diccionario_pokemones[indice]);
            }
            else
            {
                Console.WriteLine("no existe");
            }

            if (diccionario_pokemones.ContainsValue("charmander"))
            {
                Console.WriteLine("existe");
            }
            else
            {
                Console.WriteLine("no existe");
            }

            
        }
    }
}
