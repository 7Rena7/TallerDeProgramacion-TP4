using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;      //Expresada en meses

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fechaDeHoy = DateTime.Today;
            DateTime fechaIngresoEmpleoCliente = pSolicitud.Cliente.Empleo.FechaIngreso;
            //Tomando como fehcaIngresoEmpleoCliente siempre menor que fechaDeHoy
            int antiguedadLaboralCliente = ((fechaIngresoEmpleoCliente.Year - fechaDeHoy.Year) * 12) + fechaIngresoEmpleoCliente.Month - fechaDeHoy.Month;
            // antiguedadLaboralCliente esta expresado en meses para poder compararla con iAntiguedadMinima

            if (antiguedadLaboralCliente >= this.iAntiguedadMinima) { return true; }
            else { return false; }
        }
    }
}
