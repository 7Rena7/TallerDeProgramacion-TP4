using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo
        {
            get { return this.iSueldo; }
            private set { }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
            private set { }
        }

        public int AntiguedadLaboralEnMeses()
        {
            DateTime fechaDeHoy = DateTime.Today;
            DateTime fechaIngresoEmpleoCliente = this.iFechaIngreso;
            //Tomando como fehcaIngresoEmpleoCliente siempre menor que fechaDeHoy
            int antiguedadLaboral = Math.Abs(((fechaIngresoEmpleoCliente.Year - fechaDeHoy.Year) * 12) + fechaIngresoEmpleoCliente.Month - fechaDeHoy.Month);
            return antiguedadLaboral;
        }
    }
}
