using System;
using System.Collections.Generic;

namespace Listas_Propiedades_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente oCliente1 = new Cliente("Cisco", "Loberse", "piki", 32, "AV San Martin123");
            Cliente oCliente2 = new Cliente("Chuck", "Martinez", "Graizaro", 33, "Belgrano174");
            Cliente oCliente3 = new Cliente("Flor", "Cruz", "Yanse", 32, "Arrow74");




            List<Cliente> lista_clientes = new List<Cliente> 
            {
                oCliente1,
                oCliente2,
                oCliente3,
            };

            lista_clientes.Add(new Cliente("Wuacho", "Yanse", "Villaverde", 32, "Av Siempre viva 123")); // Permite agregar elementos a una lista

            lista_clientes.Clear(); // Permite eliminar elementos de una lista

            List<Cliente> lista_clientes2 = new List<Cliente>
            {
                new Cliente("Facu", "Ruiz Diaz", "Fagiani", 34, "Yapeyú 700")
            };

            lista_clientes2.AddRange(lista_clientes); // Permite agregar una lista dentro de otra


            foreach(Cliente nombre_cliente in lista_clientes2)
            {
                Console.WriteLine(nombre_cliente.getNombre());
            }

            Console.WriteLine(lista_clientes2.Count);
                
            
       
        }
    }
}
