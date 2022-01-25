using System;

namespace Combo_Box{

    public class Persona {

       private int id;
       private string nombre;



       public Persona(int id, string nombre){

            this.id = id;

            this.nombre = nombre;



       }

       
       public int Id{


          get{

               return id;

          }


       } 

       public string Nombre{

          get{

               return nombre;

          }


       }



    }


}
