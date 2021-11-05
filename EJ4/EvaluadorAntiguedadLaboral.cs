using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;      //Expresada en meses

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int antiguedadLaboralCliente = pSolicitud.Cliente.Empleo.AntiguedadLaboralEnMeses();
            // antiguedadLaboralCliente esta expresado en meses para poder compararla con iAntiguedadMinima

            if (antiguedadLaboralCliente >= this.iAntiguedadMinima) { return true; }
            else { return false; }
        }
    }
}
