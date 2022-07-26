using Xunit;
using Application.Refrescos.Implementations;
using Domain.Refrescos.Entities;
using System.Collections.Generic;
using Domain.Refrescos.Repositories;
using System.Linq;
using Moq;
using FluentAssertions;
using System;

namespace Tests
{
    public class RefrescosTest
    {
        List<Refresco> refrescoList = new List<Refresco>() {
                new Refresco(10, "Coca Cola", 500.0, 0),
                new Refresco(8, "Pepsi", 600.0, 0),
                new Refresco(10, "Fanta", 550.0, 0),
                new Refresco(15, "Sprite", 725.0, 0),
        };

        List<Refresco> refrescoModificado = new List<Refresco>() {
                    new Refresco(10, "Coca Cola", 500.0, 5),
                    new Refresco(8, "Pepsi", 600.0, 2),
                    new Refresco(10, "Fanta", 550.0, 2),
                    new Refresco(15, "Sprite", 725.0, 2),
        };

        [Fact]
        public void CrearInventario()
        {
            //arrange
            var mockRefrescoRepository = new Mock<IRefrescoRepository>();
            var refrescoService = new RefrescoService(mockRefrescoRepository.Object);
            mockRefrescoRepository.Setup(repo => repo.CrearInventario()).Returns(refrescoList);

            //act
            var inventarioRefrescos = refrescoService.CrearInventario();

            //assert
            mockRefrescoRepository.Verify(repo => repo.CrearInventario());
            inventarioRefrescos.Should().NotBeNull();
        }

        [Fact]
        public void ActualizarInventario()
        {


            List<Refresco> refrescoListActualizado = new List<Refresco>() {
                    new Refresco(5, "Coca Cola", 500.0, 0),
                    new Refresco(6, "Pepsi", 600.0, 0),
                    new Refresco(8, "Fanta", 550.0, 0),
                    new Refresco(13, "Sprite", 725.0, 0),
            };
            //arrange
            var mockRefrescoRepository = new Mock<IRefrescoRepository>();
            var refrescoService = new RefrescoService(mockRefrescoRepository.Object);
            mockRefrescoRepository.Setup(repo => repo.ActualizarInventario(refrescoModificado)).Returns(refrescoListActualizado);

            //act
            var inventarioRefrescos = refrescoService.ActualizarInventario(refrescoModificado);

            //assert
            mockRefrescoRepository.Verify(repo => repo.ActualizarInventario(refrescoModificado));
            inventarioRefrescos.Should().NotBeNull();
        }

        [Fact]
        public void ObtenerPrecioTotal()
        {
            //arrange
            var mockRefrescoRepository = new Mock<IRefrescoRepository>();
            var refrescoService = new RefrescoService(mockRefrescoRepository.Object);
            mockRefrescoRepository.Setup(repo => repo.ObtenerPrecioTotal(refrescoModificado)).Returns(Convert.ToDouble(refrescoModificado.Sum(e => e.CantidadSolicitada * e.Precio)));

            //act
            var precioFrescos = refrescoService.ObtenerPrecioTotal(refrescoModificado);

            //assert
            mockRefrescoRepository.Verify(repo => repo.ObtenerPrecioTotal(refrescoModificado));
            precioFrescos.Should().Be(6250.0);
        }
    }
}