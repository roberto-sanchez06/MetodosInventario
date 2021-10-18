using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;

namespace AppCore.Interfaces
{
    public interface IValoracionInventario
    {
        decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s);
        decimal CalcularValorExist(MovAlmacen[] ma );
        void Vender(ref IMovimientoService ent, int salida);
    }
}
