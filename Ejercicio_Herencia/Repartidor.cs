using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    public class Repartidor: Empleado
    {
        private string zona;

        public void setZona(string zona)
        {
            this.zona = zona;
        }

        public override double elPlus()
        {

            if (getEdad() < 35 && zona == "3")
            {

                return getSalario() + getPlus();


            }
            else return getSalario();
            
        }
    }
}
