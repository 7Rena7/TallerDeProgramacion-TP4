using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            double montoSolicitado = pSolicitud.Monto;
            if (montoSolicitado <= this.iMontoMaximo) { return true; }
            else { return false; }
        }
    }
}
