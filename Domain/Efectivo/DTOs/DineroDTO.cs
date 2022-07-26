using System;


namespace Domain.Efectivo.DTOs
{
    public class DineroDTO
    {
        public double Denominacion { get; set; }
        public int Cantidad { get; set; }
        
        public DineroDTO(double denominacion, int cantidad)
        {
            Denominacion = denominacion;
            Cantidad = cantidad;
        }
    }
}
