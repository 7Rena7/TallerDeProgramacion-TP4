using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class GestorPrestamos
    {
        //Nose si la relacion tiene que ser Cliente-IEvaluador
        private static Dictionary<Cliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<Cliente, IEvaluador>();

        public GestorPrestamos()
        {
            /*int antiguedadLaboralMinima = 6;
            int edadMinima = 18;
            int edadMaxima = 75;
            double sueldoMinimo = 5000;
            int cuotasMaximasSolicitadasNoCliente = 12;
            int cuotasMaximasSolicitadasCliente = 32;
            int cuotasMaximasSolicitadasClienteGold = 60;
            int cuotasMaximasSolicitadasClientePremium = 60;
            double montoMaximoSolicitadoNoCliente = 20000;
            double montoMaximoSolicitadoCliente = 100000;
            double montoMaximoSolicitadoClienteGold = 150000;
            double montoMaximoSolicitadoClientePremium = 200000;

            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima));

            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, new EvaluadorEdad(edadMinima, edadMaxima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, new EvaluadorEdad(edadMinima, edadMaxima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, new EvaluadorEdad(edadMinima, edadMaxima));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorEdad(edadMinima, edadMaxima));

            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, new EvaluadorSueldo(sueldoMinimo));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, new EvaluadorSueldo(sueldoMinimo));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, new EvaluadorSueldo(sueldoMinimo));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorSueldo(sueldoMinimo));

            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasNoCliente));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasCliente));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClienteGold));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClientePremium));

            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, new EvaluadorMonto(montoMaximoSolicitadoNoCliente));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, new EvaluadorMonto(montoMaximoSolicitadoCliente));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, new EvaluadorMonto(montoMaximoSolicitadoClienteGold));
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePlatinum, new EvaluadorMonto(montoMaximoSolicitadoClientePremium));*/
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int antiguedadLaboralMinima = 6;
            int edadMinima = 18;
            int edadMaxima = 75;
            double sueldoMinimo = 5000;
            int cuotasMaximasSolicitadasNoCliente = 12;
            int cuotasMaximasSolicitadasCliente = 32;
            int cuotasMaximasSolicitadasClienteGold = 60;
            int cuotasMaximasSolicitadasClientePremium = 60;
            double montoMaximoSolicitadoNoCliente = 20000;
            double montoMaximoSolicitadoCliente = 100000;
            double montoMaximoSolicitadoClienteGold = 150000;
            double montoMaximoSolicitadoClientePremium = 200000;

            int tipoCliente = (int)pSolicitud.Cliente.TipoCliente;

            IEvaluador evaluadorAntiguedadLaboral;
            iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima));
            iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente, out evaluadorAntiguedadLaboral);
            bool validezAntiguedad = evaluadorAntiguedadLaboral.EsValida(pSolicitud);

            IEvaluador evaluadorEdad;
            iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorEdad(edadMinima, edadMaxima));
            iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente, out evaluadorEdad);
            bool validezEdad = evaluadorEdad.EsValida(pSolicitud);

            IEvaluador evaluadorSueldo;
            iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorSueldo(sueldoMinimo));
            iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente, out evaluadorSueldo);
            bool validezSueldo = evaluadorSueldo.EsValida(pSolicitud);

            IEvaluador evaluadorCantidadCuotas;
            IEvaluador evaluadorMontoSolicitado;

            switch (tipoCliente)
            {
                case 1:
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasNoCliente));
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorMonto(montoMaximoSolicitadoNoCliente));
                    break;

                case 2:
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasCliente));
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorMonto(montoMaximoSolicitadoCliente));
                    break;

                case 3:
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClienteGold));
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorMonto(montoMaximoSolicitadoClienteGold));
                    break;

                case 4:
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClientePremium));
                    iEvaluadoresPorCliente.Add(pSolicitud.Cliente, new EvaluadorMonto(montoMaximoSolicitadoClientePremium));
                    break;
            }

            iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente, out evaluadorCantidadCuotas);
            bool validezCantidadCuotas = evaluadorSueldo.EsValida(pSolicitud);

            iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente, out evaluadorMontoSolicitado);
            bool validezMontoSolicitado = evaluadorSueldo.EsValida(pSolicitud);

            if (validezAntiguedad && validezEdad && validezSueldo && validezCantidadCuotas && validezMontoSolicitado)
            {
                return true;
            }
            else { return false; }
        }
    }
}
