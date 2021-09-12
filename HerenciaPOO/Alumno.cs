using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaPOO
{
    public class Alumno : Persona
    {

        private Boolean aprobado;


        public void setAprobado(Boolean aprobado)
        {
            this.aprobado = aprobado;
        }

        public Boolean getAprobado()
        {
            return this.aprobado;
        }
    }
      

}
