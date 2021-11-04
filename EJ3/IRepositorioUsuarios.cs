using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    interface IRepositorioUsuarios
    {
        public void Agregar(Usuario pUsuario);

        public void Actualizar(Usuario pUsuario);

        public void Eliminar(String pCodigo);

        public IList<Usuario> ObtenerTodos();

        public Usuario ObtenerPorCodigo(String pCodigo);

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador); 

    }
}
