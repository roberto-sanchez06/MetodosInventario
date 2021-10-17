using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoPromPonderado : IValoracionInventario
    {
        public decimal CalcularCostoVenta()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularCostoVenta(ref Entrada[] ent, Salida s)
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
    }
}
