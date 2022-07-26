using Xunit;
using Application.Efectivo.Implementations;
using Domain.Efectivo.Entities;
using System.Collections.Generic;
using Domain.Efectivo.Repositories;
using System.Linq;
using Moq;
using FluentAssertions;
using System;

namespace Tests
{
    public class EfectivoTest
    {
        IList<Dinero> cambioMaquina = new List<Dinero>() {
            new Dinero(500.0, 20),
            new Dinero(100.0, 30),
            new Dinero(50.0, 50),
            new Dinero(25.0, 25),
        };

        IList<Dinero> dineroCliente = new List<Dinero>() {
            new Dinero(1000.0, 0),
            new Dinero(500.0, 0),
            new Dinero(100.0, 0),
            new Dinero(50.0, 0),
            new Dinero(25.0, 0),
        };

        [Fact]
        public void CrearFondo()
        {
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.CrearFondo()).Returns(cambioMaquina);

            //act
            var dineroMaquina = dineroService.CrearFondo();

            //assert
            mockDineroRepository.Verify(repo => repo.CrearFondo());
            dineroMaquina.Should().NotBeNull();
        }

        [Fact]
        public void CrearListaCliente()
        {
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.CrearListaCliente()).Returns(dineroCliente);

            //act
            var dineroEntrante = dineroService.CrearListaCliente();

            //assert
            mockDineroRepository.Verify(repo => repo.CrearListaCliente());
            dineroEntrante.Should().NotBeNull();
        }

        [Fact]
        public void ActualizarDinero()
        {
            IList<Dinero> dineroEntrante = new List<Dinero>() {
                new Dinero(1000.0, 0),
                new Dinero(500.0, 3),
                new Dinero(100.0, 0),
                new Dinero(50.0, 0),
                new Dinero(25.0, 0),
            };

            IList<Dinero> cambioNuevoMaquina = new List<Dinero>() {
                new Dinero(500.0, 23),
                new Dinero(100.0, 30),
                new Dinero(50.0, 50),
                new Dinero(25.0, 25),
            };
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.ActualizarDinero(dineroEntrante)).Returns(cambioNuevoMaquina);

            //act
            var nuevoDineroMaquina = dineroService.ActualizarDinero(dineroEntrante);

            //assert
            mockDineroRepository.Verify(repo => repo.ActualizarDinero(dineroEntrante));
            nuevoDineroMaquina.Where(e=> e.Denominacion == 500.0).First().Cantidad.Should().Be(23);
        }

        [Fact]
        public void ObtenerMontoLista()
        {
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.ObtenerMontoLista(cambioMaquina)).Returns(cambioMaquina.Sum(e=> e.Denominacion*e.Cantidad));

            //act
            var dineroEntrante = dineroService.ObtenerMontoLista(cambioMaquina);

            //assert
            mockDineroRepository.Verify(repo => repo.ObtenerMontoLista(cambioMaquina));
            dineroEntrante.Should().Be(16125.0);
        }

        [Fact]
        public void ObtenerVuelto()
        {
            double vuelto = 275.0;

            IList<Dinero> vueltoLista = new List<Dinero>() {
                new Dinero(500.0, 0),
                new Dinero(100.0, 2),
                new Dinero(50.0, 1),
                new Dinero(25.0, 1),
            };
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.ObtenerVuelto(vuelto)).Returns(vueltoLista);

            //act
            var nuevoCambioMaquina = dineroService.ObtenerVuelto(vuelto);

            //assert
            mockDineroRepository.Verify(repo => repo.ObtenerVuelto(vuelto));
            nuevoCambioMaquina.Where(e => e.Denominacion == 500.0).First().Cantidad.Should().Be(0);
            nuevoCambioMaquina.Where(e => e.Denominacion == 100.0).First().Cantidad.Should().Be(2);
            nuevoCambioMaquina.Where(e => e.Denominacion == 50.0).First().Cantidad.Should().Be(1);
            nuevoCambioMaquina.Where(e => e.Denominacion == 25.0).First().Cantidad.Should().Be(1);
        }

        [Fact]
        public void PagarVuelto()
        {
            IList<Dinero> dineroEntrante = new List<Dinero>() {
                new Dinero(1000.0, 0),
                new Dinero(500.0, 3),
                new Dinero(100.0, 0),
                new Dinero(50.0, 0),
                new Dinero(25.0, 0),
            };

            IList<Dinero> cambioMaquinaModificado = new List<Dinero>() {
                new Dinero(500.0, 17),
                new Dinero(100.0, 30),
                new Dinero(50.0, 50),
                new Dinero(25.0, 25),
            };
            //arrange
            var mockDineroRepository = new Mock<IDineroRepository>();
            var dineroService = new DineroService(mockDineroRepository.Object);
            mockDineroRepository.Setup(repo => repo.PagarVuelto(dineroEntrante)).Returns(cambioMaquinaModificado);

            //act
            var nuevoCambioMaquina = dineroService.PagarVuelto(dineroEntrante);

            //assert
            mockDineroRepository.Verify(repo => repo.PagarVuelto(dineroEntrante));
            nuevoCambioMaquina.Where(e=>e.Denominacion == 500.0).First().Cantidad.Should().Be(17);
        }
    }
}