
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Persons.DTOs
{
    public class PersonsDTO
    {
        public int CantidadDisponible { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadSolicitada { get; set; }

        public PersonsDTO(int cantidadDisponible, String nombre,
            double precio, int cantidadSolicitada)
        {
            CantidadDisponible = cantidadDisponible;
            Nombre = nombre;
            Precio = precio;
            CantidadSolicitada = cantidadSolicitada;
        }
    }
}
