using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public void setNombreYapellido(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string getNombreYapellido()
        {

            return  nombre + " " + apellido;
            
        }


    }
}
