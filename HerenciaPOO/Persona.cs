using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaPOO
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public void setNombre(string nombre)
        {

            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {

            this.apellido = apellido;
        }

        public string getNombreApellido()
        {

            return this.nombre + " " + this.apellido;
        }
    }
}
