using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class Usuario : IComparable<Usuario>
    {
        string iCodigo, iNombreCompleto, iCorreoElectronico; 

        public Usuario(string pCodigo, string pCorreo, string pNombreCompleto)
        {
            this.iCodigo = pCodigo;
            this.iCorreoElectronico = pCorreo;
            this.iNombreCompleto = pNombreCompleto;
        }
        public string Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }

        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
            set { this.iNombreCompleto = value; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
            set { this.iCorreoElectronico = value; }
        }

        public int CompareTo(Usuario pUsuario)
        {
            if (pUsuario == null) return 1;

            Usuario otroUsuario = pUsuario as Usuario; // realizar casteo del objeto a comparar
            if (otroUsuario != null)
                return this.Codigo.CompareTo(otroUsuario.Codigo);
            else
                throw new ArgumentException("El Objeto no es un Usuario");
        }

        // Definir el operador mayor que.
        public static bool operator >(Usuario pUsuario1, Usuario pUsuario2)
        {
            return pUsuario1.CompareTo(pUsuario2) == 1;
        }

        // Definir el operador menor que.
        public static bool operator <(Usuario pUsuario1, Usuario pUsuario2)
        {
            return pUsuario1.CompareTo(pUsuario2) == -1;
        }

        // Definir el operador mayor o igual que.
        public static bool operator >=(Usuario pUsuario1, Usuario pUsuario2)
        {
            return pUsuario1.CompareTo(pUsuario2) >= 0;
        }

        // Definir el operador menor o igual que.
        public static bool operator <=(Usuario pUsuario1, Usuario pUsuario2)
        {
            return pUsuario1.CompareTo(pUsuario2) <= 0;
        }

    }
}
