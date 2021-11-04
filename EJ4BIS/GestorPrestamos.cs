using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class GestorPrestamos
    {
        //Nose si la relacion tiene que ser Cliente-IEvaluador
        private static Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

        public GestorPrestamos()
        {
            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorAntiguedadLaboral(6));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorAntiguedadLaboral(6));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorAntiguedadLaboral(6));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorAntiguedadLaboral(6));

            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorEdad(18, 75));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorEdad(18, 75));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorEdad(18, 75));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorEdad(18, 75));

            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorSueldo(5000));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorSueldo(5000));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorSueldo(5000));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorSueldo(5000));

            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorCantidadCuotas(12));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorCantidadCuotas(32));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorCantidadCuotas(60));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorCantidadCuotas(60));

            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, new EvaluadorMonto(20000));
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluadorMonto(100000));
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, new EvaluadorMonto(150000));
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorMonto(200000));
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            throw new NotImplementedException();
        }
    }
}
