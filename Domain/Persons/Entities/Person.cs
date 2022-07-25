using System;

namespace Domain.Persons.Entities
{
    public class Person
    {
        public int CantidadDispobile { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadSolicitada { get; set; }

        public Person(int cantidadDisponible, String nombre,
            double precio, int cantidadSolicitada)
        {
            CantidadDispobile = cantidadDisponible;
            Nombre = nombre;
            Precio = precio;
            CantidadSolicitada = cantidadSolicitada;
        }
    }
}
