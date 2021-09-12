using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_Propiedades_Metodos
{
    public class Cliente
    {
        // Atributos de clase

        private string nombre;
        private String a_paterno;
        private string a_materno;
        private int edad;
        private string direccion;

        // Constructor

        public Cliente(string nombre, string a_paterno, string a_materno, int edad, string direccion)
        {
            this.nombre = nombre;
            this.a_paterno = a_paterno;
            this.a_materno = a_materno;
            this.edad = edad;
            this.direccion = direccion;

        }

        // Métodos set y get

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApaterno(string a_paterno)
        {

            this.a_paterno = a_paterno;

        }

        public void setMaterno(string a_materno)
        {

            this.a_materno = a_materno;

        }

        public void setEdad(int edad)
        {
            this.edad = edad;

        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApaterno()
        {
            return this.a_paterno;
        }

        public string getAmaterno()
        {
            return this.a_materno;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public string getDireccion()
        {
            return this.direccion;
        }

    }
}
