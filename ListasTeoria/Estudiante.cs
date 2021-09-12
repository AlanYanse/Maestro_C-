using System;
using System.Collections.Generic;
using System.Text;

namespace ListasTeoria
{
    public class Estudiante
    {
        private string nombre;
        private double nota1;
        private double nota2;

        public Estudiante(string nombre, double nota1, double nota2)
        {

            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        public double getNota2()
        {
            return this.nota2;
        }
    }
}
