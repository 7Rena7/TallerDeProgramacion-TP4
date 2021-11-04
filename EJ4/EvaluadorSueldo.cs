using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorSueldo : IEvaluador
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            double sueldoCliente = pSolicitud.Cliente.Empleo.Sueldo;
            if (sueldoCliente >= this.iSueldoMinimo) { return true; }
            else { return false; }
        }
    }
}
