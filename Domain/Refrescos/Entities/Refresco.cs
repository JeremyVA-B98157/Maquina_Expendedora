using System;

namespace Domain.Refrescos.Entities
{
    public class Refresco
    {
        public int CantidadDisponible { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int? CantidadSolicitada { get; set; }

        public Refresco(int cantidadDisponible, String nombre,
            double precio, int cantidadSolicitada)
        {
            CantidadDisponible = cantidadDisponible;
            Nombre = nombre;
            Precio = precio;
            CantidadSolicitada = cantidadSolicitada;
        }
    }
}
