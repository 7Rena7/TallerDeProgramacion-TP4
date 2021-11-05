using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class Cliente
    {
        private String iNombre;
        private String iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        
        //Constructor para que un cliente sea iniciado como No Cliente
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iTipoCliente = 0;
            this.iEmpleo = pEmpleo;
        }

        //Constructor para indicar que tipo de cliente es
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo, TipoCliente pTipoCliente)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iTipoCliente = pTipoCliente;
            this.iEmpleo = pEmpleo;
        }

        public String Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        public String Apelido
        {
            get { return this.iApellido; }
            private set { }
        }

        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
            private set { }
        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
            private set { }
        }

        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            private set { }
        }

        public int EdadEnAnios()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime fechaDeHoy = DateTime.Today;
            DateTime fechaNacimientoCliente = this.FechaNacimiento;
            TimeSpan span = fechaDeHoy - fechaNacimientoCliente;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int edadCliente = (zeroTime + span).Year - 1;
            return edadCliente;
        }
    }
}
