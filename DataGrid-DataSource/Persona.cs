using System;

namespace DataGrid_DataSource
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;


        public string Nombre{
           
            get{

                return nombre;
            }

            set{

               this.nombre = value;
            }
        }
        
        public string  Apellido{
            
            get{

                return apellido;
            }

            set{

               this.apellido = value;
            }
        }

        public int  Edad{

            get{
                
                return edad;
            }

            set{

               this.edad = value;
            }

        }

    }
}
