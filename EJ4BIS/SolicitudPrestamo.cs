using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class SolicitudPrestamo
    {
        private double iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
            this.iCliente = pCliente;
        }

        public double Monto
        {
            get { return this.iMonto; }
            private set { }
        }

        public int CantidadCuotas
        {
            get { return this.iCantidadCuotas; }
            private set { }
        }

        public Cliente Cliente
        {
            get { return this.iCliente; }
            private set { }
        }


    }
}
