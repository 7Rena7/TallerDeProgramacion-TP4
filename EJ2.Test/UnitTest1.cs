using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EJ2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Agregar()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");


            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);
        }
        [Fact]
        public void AgregarCodigoDuplicado()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("rtf", "@gmail.com", "Juan5");


            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);
        }

        [Fact]
        public void Actualizar()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario = new Usuario("txt", "@gmail.com", "Juan1");

            repositorio.Agregar(usuario);

            Usuario usuarioActualizado = new Usuario("txt", "hola@gmail.com", "Juan");

            repositorio.Actualizar(usuarioActualizado);

        }

        [Fact]
        public void ActualizarAlgoQueNoExiste()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario = new Usuario("txt", "@gmail.com", "Juan1");

            //repositorio.Agregar(usuario);

            Usuario usuario2 = new Usuario("abc", "@gmail.com", "Juan");

            repositorio.Actualizar(usuario2);

        }

        [Fact]
        public IList<Usuario> ObtenerTodos()
        {
            Repositorio repositorio = new Repositorio();

            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");

            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);
            return repositorio.ObtenerTodos();

        }

        [Fact]
        public void Eliminar()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");

            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);

            repositorio.Eliminar("txt");
        }

        [Fact]
        public void EliminarAlgoQueNoExiste()
        {
            Repositorio repositorio = new Repositorio();
            //Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");

           // repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);

            repositorio.Eliminar("txt");
        }

        [Fact]
        public Usuario Obtener()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");

            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);

            return repositorio.ObtenerPorCodigo("dib");
        }

        [Fact]
        public Usuario ObtenerAlgoQueNoExiste()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            //Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");

            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            //repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);

            return repositorio.ObtenerPorCodigo("dib");
        }
    }
}
