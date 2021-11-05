using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edadCliente = pSolicitud.Cliente.EdadEnAnios();
            //edadCliente experesada en años

            if (edadCliente >= this.iEdadMinima && edadCliente <= this.iEdadMaxima) { return true; }
            else { return false; }

        }
    }
}
