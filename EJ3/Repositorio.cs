﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Repositorio : IRepositorioUsuarios
    {
        SortedList<string, Usuario> coleccion = new SortedList<string, Usuario>();
        public void Agregar(Usuario pUsuario)
        {
            try
            {
                coleccion.Add(pUsuario.Codigo, pUsuario);
            }
            catch (AgregarExcepcion)
            {
                throw new AgregarExcepcion($"El usuario con el codigo {pUsuario.Codigo} ya existe");
            }
        }
        
        public void Actualizar(Usuario pUsuario)
        {

            if (coleccion[pUsuario.Codigo].Codigo == pUsuario.Codigo)
            {
                coleccion[pUsuario.Codigo] = pUsuario;
            }
            else
            {
                throw new ActualizarException($"El usuario con el codigo {pUsuario.Codigo} no existe");
            }

        }

        public void Eliminar(String pCodigo)
        {
            try
            {
                Usuario usuario = ObtenerPorCodigo(pCodigo);
                coleccion.Remove(pCodigo);
            }
            catch (EliminarExeption)
            {
                throw new EliminarExeption ($"El usuario no existe"); ;
            }
        }

        public IList<Usuario> ObtenerTodos()
        {
            IList<Usuario> listadeUsuarios = coleccion.Values;
            return listadeUsuarios;

        }

        public Usuario ObtenerPorCodigo(String pCodigo)
        {
            try
            {
                return coleccion[pCodigo];
            }
            catch (BusquedaException)
            {
                throw new BusquedaException($"La clave {pCodigo} no existe");
            }
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (var item in coleccion) { lista.Add(item.Value); }
            lista.Sort(pComparador);
            return lista;
        }

        public bool ConsultarUsuarioExistente(Usuario pUsuario)
        {
            IList<Usuario> lista = new List<Usuario>();
            foreach (var item in coleccion) { lista.Add(item.Value); } 

            foreach (var item in coleccion)
            {
                if (lista.Contains(pUsuario))
                    return true;
            }
            return false;
        }

    }
}
