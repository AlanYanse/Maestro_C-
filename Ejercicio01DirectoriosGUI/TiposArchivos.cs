using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01DirectoriosGUI
{
    public class TiposArchivos
    {
        private string archivo;
        private string nombreArchivo;

        public String Archivo
        {
            get
            {
                return archivo;
            }
            set
            {
                this.archivo = value;
            }
        }

        public string NombreArchivo
        {
            get
            {
                return nombreArchivo;
            }
            set
            {
                this.nombreArchivo = value;
            }
        }

    }
}
