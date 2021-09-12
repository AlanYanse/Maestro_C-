using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Cliente: Persona
    {
        public string gustos;

        public void setGustos(string gustos)
        {
            this.gustos = gustos;
        }

        public string getGustos()
        {
            return gustos;
        }
    }
}
