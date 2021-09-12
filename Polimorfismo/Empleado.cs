using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Empleado: Persona
    {
        private double sueldo;

        public void setSueldo(double sueldo)
        {
            this.sueldo = sueldo;

        }

        public double getSueldo()
        {
            return sueldo;
        }
    }
}
