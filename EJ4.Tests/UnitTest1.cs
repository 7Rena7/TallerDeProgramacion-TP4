using System;
using Xunit;
using EJ4;

namespace EJ4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleAntiguedadLaboral()
        {
            //Arrange
            bool expected = true;
            int antiguedadLaboralMinima = 6;
            EvaluadorAntiguedadLaboral unEvaluador = new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima);

            //Act
            Empleo empleo1 = new Empleo(5000, new DateTime(2018, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 01, 01), empleo1);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleAntiguedadLaboral_2()
        {
            //Arrange
            bool expected = true;
            int antiguedadLaboralMinima = 6;
            EvaluadorAntiguedadLaboral unEvaluador = new EvaluadorAntiguedadLaboral(antiguedadLaboralMinima);

            //Act
            Empleo empleo1 = new Empleo(5000, new DateTime(2019, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 01, 01), empleo1, TipoCliente.ClienteGold);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleSueldoMinimo()
        {
            //Arrange
            bool expected = true;
            double sueldoMinimo = 5000;
            EvaluadorSueldo unEvaluador = new EvaluadorSueldo(sueldoMinimo);

            //Act
            Empleo empleo1 = new Empleo(6000, new DateTime(2018, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 01, 01), empleo1);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleSueldoMinimo_2()
        {
            //Arrange
            bool expected = true;
            double sueldoMinimo = 5000;
            EvaluadorSueldo unEvaluador = new EvaluadorSueldo(sueldoMinimo);

            //Act
            Empleo empleo1 = new Empleo(5000, new DateTime(2018, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 01, 01), empleo1);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleRangoEdad()
        {
            //Arrange
            bool expected = true;
            int edadMinima = 18;
            int edadMaxima = 85;
            EvaluadorEdad unEvaluador = new EvaluadorEdad(edadMinima, edadMaxima);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2018, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 01, 01), empleo1);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleRangoEdad_2()
        {
            //Arrange
            bool expected = true;
            int edadMinima = 18;
            int edadMaxima = 85;
            EvaluadorEdad unEvaluador = new EvaluadorEdad(edadMinima, edadMaxima);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2018, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2003, 10, 15), empleo1);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 15000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleMontoSegunTipoCliente()
        {
            //Arrange
            bool expected = true;
            double montoMaximoSolicitadoClienteGold = 150000;
            EvaluadorMonto unEvaluador = new EvaluadorMonto(montoMaximoSolicitadoClienteGold);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.ClienteGold);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 125000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleMontoSegunTipoCliente_2()
        {
            //Arrange
            bool expected = true;
            double montoMaximoSolicitadoNoCliente = 15000;
            EvaluadorMonto unEvaluador = new EvaluadorMonto(montoMaximoSolicitadoNoCliente);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.NoCliente);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 13000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleMontoSegunTipoCliente_3()
        {
            //Arrange
            bool expected = true;
            double montoMaximoSolicitadoClientePremium = 200000;
            EvaluadorMonto unEvaluador = new EvaluadorMonto(montoMaximoSolicitadoClientePremium);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.ClientePremium);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 180000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleMontoSegunTipoCliente2()
        {
            //Arrange
            bool expected = true;
            double montoMaximoSolicitadoClientePremium = 200000;
            EvaluadorMonto unEvaluador = new EvaluadorMonto(montoMaximoSolicitadoClientePremium);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.ClientePremium);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 200000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleNumeroCuotasSegunTipoCliente()
        {
            //Arrange
            bool expected = true;
            int cuotasMaximasSolicitadasNoCliente = 12;
            EvaluadorCantidadCuotas unEvaluador = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasNoCliente);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.NoCliente);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 10000, 10);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValidaCuandoCumpleNumeroCuotasSegunTipoCliente_2()
        {
            //Arrange
            bool expected = true;
            int cuotasMaximasSolicitadasClientePremium = 60;
            EvaluadorCantidadCuotas unEvaluador = new EvaluadorCantidadCuotas(cuotasMaximasSolicitadasClientePremium);

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2016, 01, 01));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(2000, 09, 15), empleo1, TipoCliente.ClientePremium);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 10000, 55);
            bool actual = unEvaluador.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValida_NoCliente()
        {
            //Arrange
            bool expected = true;
            GestorPrestamos unGestor = new GestorPrestamos();

            //Act
            Empleo empleo1 = new Empleo(8000, new DateTime(2020, 12, 20));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(1995, 03, 12), empleo1, TipoCliente.NoCliente);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 12000, 12);

            bool actual = unGestor.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValida_Cliente()
        {
            //Arrange
            bool expected = true;
            GestorPrestamos unGestor = new GestorPrestamos();

            //Act
            Empleo empleo1 = new Empleo(10000, new DateTime(2021, 02, 15));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(1993, 05, 02), empleo1, TipoCliente.Cliente);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 20000, 24);

            bool actual = unGestor.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValida_ClienteGold()
        {
            //Arrange
            bool expected = true;
            GestorPrestamos unGestor = new GestorPrestamos();

            //Act
            Empleo empleo1 = new Empleo(18000, new DateTime(2021, 03, 15));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(1993, 05, 02), empleo1, TipoCliente.ClienteGold);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 100000, 50);

            bool actual = unGestor.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SolicitudDeberiaSerValida_ClientePremium()
        {
            //Arrange
            bool expected = true;
            GestorPrestamos unGestor = new GestorPrestamos();

            //Act
            Empleo empleo1 = new Empleo(30000, new DateTime(2018, 06, 05));
            Cliente cliente1 = new Cliente("Juan", "Perez", new DateTime(1980, 05, 02), empleo1, TipoCliente.ClientePremium);
            SolicitudPrestamo solicitud1 = new SolicitudPrestamo(cliente1, 200000, 60);

            bool actual = unGestor.EsValida(solicitud1);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
