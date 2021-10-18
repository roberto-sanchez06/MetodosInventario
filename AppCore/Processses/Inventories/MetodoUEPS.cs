using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoUEPS : IValoracionInventario
    {
        public decimal CalcularCostoVenta(ref Entrada[] ent, Salida s)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularValorExist(MovAlmacen[] ma)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularValorInventario()
        {
            throw new NotImplementedException();
        }

        public void Vender(ref Entrada[] ent, int salida)
        {
            throw new NotImplementedException();
        }

        public void Vender(ref IMovimientoService ent, int salida)
        {
            throw new NotImplementedException();
        }
    }
}
