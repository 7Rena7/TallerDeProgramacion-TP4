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
    }
}
