using System;

namespace Domain.Efectivo.Entities
{
    public class Dinero
    {
        public double Denominacion { get; set; }
        public int Cantidad { get; set; }

        public Dinero(double denominacion, int cantidad)
        {
            Denominacion = denominacion;
            Cantidad = cantidad;
        }
    }
}
