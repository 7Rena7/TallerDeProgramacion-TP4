using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int numeroCuotasSolicitadas = pSolicitud.CantidadCuotas;
            if (numeroCuotasSolicitadas <= this.iCantidadMaximaCuotas) { return true; }
            else { return false; }
        }
    }
}
