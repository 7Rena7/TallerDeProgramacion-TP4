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
        private static Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorTipoCliente = new Dictionary<TipoCliente, IEvaluador>();

        public GestorPrestamos()
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

            EvaluadorCompuesto evaluadorNoCliente = new EvaluadorCompuesto();
            EvaluadorCompuesto evaluadorCliente = new EvaluadorCompuesto();
            EvaluadorCompuesto evaluadorClienteGold = new EvaluadorCompuesto();
            EvaluadorCompuesto evaluadorClientePremium = new EvaluadorCompuesto();

            //Evaluadores iguales para todos los Tipos de Cliente
            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(edadMinima, edadMaxima);
            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(sueldoMinimo);

            //Evaluadores particulares para No Cliente
            EvaluadorCantidadCuotas evaluadorCantidadCuotasNoCliente = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasNoCliente);
            EvaluadorMonto evaluadorMontoNoCliente = new EvaluadorMonto(montoMaximoSolicitadoNoCliente);

            //Evaluadores particulares para Cliente
            EvaluadorCantidadCuotas evaluadorCantidadCuotasCliente = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasCliente);
            EvaluadorMonto evaluadorMontoCliente = new EvaluadorMonto(montoMaximoSolicitadoCliente);

            //Evaluadores particulares para Cliente Gold
            EvaluadorCantidadCuotas evaluadorCantidadCuotasClienteGold = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClienteGold);
            EvaluadorMonto evaluadorMontoClienteGold = new EvaluadorMonto(montoMaximoSolicitadoClienteGold);

            //Evaluadores particulares para Cliente Premium
            EvaluadorCantidadCuotas evaluadorCantidadCuotasClientePremium = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClientePremium);
            EvaluadorMonto evaluadorMontoClientePremium = new EvaluadorMonto(montoMaximoSolicitadoClientePremium);

            //Agregamos todos los evaluadores al Evaluador Compuesto de cada Tipo de Cliente
            //Para el Tipo NoCliente
            evaluadorNoCliente.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorNoCliente.AgregarEvaluador(evaluadorEdad);
            evaluadorNoCliente.AgregarEvaluador(evaluadorSueldo);
            evaluadorNoCliente.AgregarEvaluador(evaluadorCantidadCuotasNoCliente);
            evaluadorNoCliente.AgregarEvaluador(evaluadorMontoNoCliente);

            //Para el Tipo Cliente
            evaluadorCliente.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorCliente.AgregarEvaluador(evaluadorEdad);
            evaluadorCliente.AgregarEvaluador(evaluadorSueldo);
            evaluadorCliente.AgregarEvaluador(evaluadorCantidadCuotasCliente);
            evaluadorCliente.AgregarEvaluador(evaluadorMontoCliente);

            //Para el Tipo ClienteGold
            evaluadorClienteGold.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorClienteGold.AgregarEvaluador(evaluadorEdad);
            evaluadorClienteGold.AgregarEvaluador(evaluadorSueldo);
            evaluadorClienteGold.AgregarEvaluador(evaluadorCantidadCuotasClienteGold);
            evaluadorClienteGold.AgregarEvaluador(evaluadorMontoClienteGold);

            //Para el Tipo ClientePremuim
            evaluadorClientePremium.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorClientePremium.AgregarEvaluador(evaluadorEdad);
            evaluadorClientePremium.AgregarEvaluador(evaluadorSueldo);
            evaluadorClientePremium.AgregarEvaluador(evaluadorCantidadCuotasClientePremium);
            evaluadorClientePremium.AgregarEvaluador(evaluadorMontoClientePremium);

            //Agregamos al Dictionary las Keys Tipos de Cliente, con sus valores que son sus EvaluadoresCompuestos correspondientes 
            iEvaluadoresPorTipoCliente.Add(TipoCliente.NoCliente, evaluadorNoCliente);
            iEvaluadoresPorTipoCliente.Add(TipoCliente.Cliente, evaluadorCliente);
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClienteGold, evaluadorClienteGold);
            iEvaluadoresPorTipoCliente.Add(TipoCliente.ClientePremium, evaluadorClientePremium);

        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            //Devuelve el Evaluador Compuesto que corresponde con el tipo de cliente que tiene pSolicitud
            IEvaluador evaluador = iEvaluadoresPorTipoCliente[pSolicitud.Cliente.TipoCliente];
            return evaluador.EsValida(pSolicitud);
        }
    }
}
