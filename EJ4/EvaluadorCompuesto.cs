using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorCompuesto : IEvaluador
    {
        private List<IEvaluador> iEvaluadores = new List<IEvaluador>();

        public EvaluadorCompuesto() { }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            foreach (IEvaluador evaluadorActual in iEvaluadores)
            {
                bool validezEvaluador = evaluadorActual.EsValida(pSolicitud);
                if (validezEvaluador == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
