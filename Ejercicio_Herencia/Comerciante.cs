using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    public class Comerciante: Empleado
    {
        private double comision;

        public void setComision(double comision)
        {
            this.comision = comision;

        }

        public double getComision()
        {
            return comision;
        }

        public override double elPlus()
        {
            if (getEdad() > 20 && getComision() > 300)
            {
                return getSalario() + getPlus();
            }
            else return getSalario();
        }
    }
}
