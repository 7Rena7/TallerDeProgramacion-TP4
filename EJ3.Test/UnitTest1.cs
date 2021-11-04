using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EJ3.Test
{
    public class UnitTest1
    {
        [Fact]
        public void VerificarUsuario1()
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
            bool resultado = repositorio.ConsultarUsuarioExistente(usuario1);

            Assert.True(resultado);
        }
        [Fact]
        public void VerificarUsuario2()
        {
            Repositorio repositorio = new Repositorio();
            Usuario usuario1 = new Usuario("txt", "@gmail.com", "Juan1");
            Usuario usuario2 = new Usuario("bmp", "@gmail.com", "Juan2");
            Usuario usuario3 = new Usuario("dib", "@gmail.com", "Juan3");
            Usuario usuario4 = new Usuario("rtf", "@gmail.com", "Juan4");
            Usuario usuario5 = new Usuario("ays", "@gmail.com", "Juan5");


            //repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario4);
            repositorio.Agregar(usuario5);
            bool resultado = repositorio.ConsultarUsuarioExistente(usuario1);

            Assert.True(resultado);
        }
    }
}
