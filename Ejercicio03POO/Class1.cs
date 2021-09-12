using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio03POO
{
    public class Alumno
    {
        private string nombre_alumno;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double promedio1;
        private double promedio2;

        public Alumno(string nombre_alumno)
        {
            this.nombre_alumno = nombre_alumno;
        }

        public string getNombre()
        {
            return this.nombre_alumno;
        }

        public double calcularPromPrimerasNotas(double nota1, double nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;

            double promedio1 = (nota1 + nota2) / 2;

            this.promedio1 = promedio1;

            return promedio1;
        }

        public double calcularPromSegundasNotas(double nota3, double nota4)
        {
            this.nota3 = nota3;
            this.nota4 = nota4;

            double promedio2 = (nota3 + nota4) / 2;

            this.promedio2 = promedio2;

            return promedio2;
        }

        public double calcularPromTotal()
        {
            double promedio_total = (this.promedio1 + this.promedio2) / 2;

            return promedio_total;
        }
    }
}
