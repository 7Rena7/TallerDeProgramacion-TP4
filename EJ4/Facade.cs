using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    static class Facade
    {
        public static void RegistrarCliente(string pNombre, string pApellido, DateTime pFechaNacimiento, double pSalario, DateTime pFechaIngreso)
        {
            Empleo empleoCliente = RegistrarEmpleo(pSalario, pFechaIngreso);
            Cliente unCliente = new Cliente(pNombre, pApellido, pFechaNacimiento, empleoCliente);
        }

        private static Empleo RegistrarEmpleo(double pSalario, DateTime pFechaIngreso)
        {
            Empleo unEmpleo = new Empleo(pSalario, pFechaIngreso);
            return unEmpleo;
        }

        public static bool RegistrarSolicitudPrestamo(Cliente pUnCliente, double pMonto, int pNumeroCuotas)
        {
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(pUnCliente, pMonto, pNumeroCuotas);
            GestorPrestamos unGestorPrestamos = new GestorPrestamos();
            bool validezSolicitud = unGestorPrestamos.EsValida(unaSolicitud);
            return validezSolicitud;
        }
    }
}
