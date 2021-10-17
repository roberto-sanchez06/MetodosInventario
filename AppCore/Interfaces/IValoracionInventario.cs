using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;

namespace AppCore.Interfaces
{
    public interface IValoracionInventario
    {
        decimal CalcularCostoVenta(ref Entrada[] ent, Salida s);
        decimal CalcularValorExist(MovAlmacen[]);
        void Vender(ref Entrada[] ent, int salida);
    }
}
