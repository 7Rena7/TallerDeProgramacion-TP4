using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class ComparadorNombreALF : IComparer<Usuario>
    {
        public int Compare(Usuario unUsuario, Usuario otroUsuario)
        {
            if (unUsuario != null && otroUsuario != null)
                return unUsuario.NombreCompleto.CompareTo(otroUsuario.NombreCompleto);
            else
                throw new ArgumentException("Uno de los Objeto no es un Usuario o es Nulo");
        }
    }
}
