using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class DivisionPorCeroException : Exception
    {
        string iMensaje;

        public DivisionPorCeroException(string pMensaje)
        {
            this.iMensaje= pMensaje;
        }

        public string Mensaje
        {
            get { return this.iMensaje; }
            private set { }
        }
    }
}
