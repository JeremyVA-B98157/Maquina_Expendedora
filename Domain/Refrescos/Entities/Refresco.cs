using System;

namespace Domain.Refrescos.Entities
{
    public class Refresco
    {
        public int CantidadDispobile { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int CantidadSolicitada { get; set; }

        public Refresco(int cantidadDisponible, String nombre,
            double precio, int cantidadSolicitada)
        {
            CantidadDispobile = cantidadDisponible;
            Nombre = nombre;
            Precio = precio;
            CantidadSolicitada = cantidadSolicitada;
        }
    }
}
