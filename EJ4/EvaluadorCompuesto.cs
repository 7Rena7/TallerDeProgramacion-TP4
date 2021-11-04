using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EvaluadorCompuesto : IEvaluador
    {
        private IEvaluador iEvaluadores;

        public EvaluadorCompuesto() { }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            throw new NotImplementedException();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
