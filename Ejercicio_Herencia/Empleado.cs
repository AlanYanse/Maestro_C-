using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    public abstract class Empleado
    {
        private string nombre;
        private int edad;
        private double salario;
        private const double PLUS = 400;

        public abstract double elPlus();

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        public double getPlus()
        {
            return PLUS;
        }
        
    }
}
