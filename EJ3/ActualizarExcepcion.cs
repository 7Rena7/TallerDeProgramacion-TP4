using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class AgregarExcepcion : Exception
    {

        string iMensaje;

        public AgregarExcepcion(string pMensaje)
        {
            this.iMensaje = pMensaje;
        }

        public string Mensaje
        {
            get { return this.iMensaje; }
            private set { }
        }
    }
}
