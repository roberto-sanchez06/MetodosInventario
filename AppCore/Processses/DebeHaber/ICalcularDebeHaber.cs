using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;

namespace AppCore.Processses.DebeHaber
{
    public interface ICalcularDebeHaber
    {
        decimal CalcularDebeHaber(MovAlmacen movAlmacen);
    }
}
