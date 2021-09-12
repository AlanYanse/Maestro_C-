using System;
using System.Collections.Generic;

namespace ListasTeoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Facu", 9, 8);

            Estudiante estudiante2 = new Estudiante("Chuck", 7, 8);

            Estudiante estudiante3 = new Estudiante("Cisco", 4, 6);

            List<Estudiante> listaEstudiantes = new List<Estudiante> {estudiante1, estudiante2, estudiante3};

            Console.WriteLine("El promedio del estudiante " + listaEstudiantes[0].getNombre() + " es " + getPromedio(listaEstudiantes[0].getNota1(), listaEstudiantes[0].getNota2()));
            Console.WriteLine("El promedio del estudiante " + listaEstudiantes[1].getNombre() + " es " + getPromedio(listaEstudiantes[1].getNota1(), listaEstudiantes[1].getNota2()));
            Console.WriteLine("El promedio del estudiante " + listaEstudiantes[2].getNombre() + " es " + getPromedio(listaEstudiantes[2].getNota1(), listaEstudiantes[2].getNota2()));

        }

        private static double getPromedio(double nota1, double nota2)
        {
            double resultado = (nota1 + nota2) / 2;

            return resultado;
        }
    }
}
