using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class ActualizarException : Exception
    {
        string iMensaje;

        public ActualizarException(string pMensaje)
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
