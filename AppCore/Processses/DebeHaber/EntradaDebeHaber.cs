using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;

namespace AppCore.Processses.DebeHaber
{
    public class EntradaDebeHaber : ICalcularDebeHaber
    {
        public decimal CalcularDebeHaber(MovAlmacen movAlmacen)
        {
            return movAlmacen.PrecioTotal;
        }
    }
}
