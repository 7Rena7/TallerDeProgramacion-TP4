using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorEdad : IEvaluador
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
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime fechaDeHoy = DateTime.Today;
            DateTime fechaNacimientoCliente = pSolicitud.Cliente.FechaNacimiento;
            TimeSpan span = fechaDeHoy - fechaNacimientoCliente;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int edadCliente = (zeroTime + span).Year - 1;
            //edadCliente experesada en años

            if (edadCliente >= this.iEdadMinima && edadCliente <= this.iEdadMaxima) { return true; }
            else { return false; }

        }
    }
}
