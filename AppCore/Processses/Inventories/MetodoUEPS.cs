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

        public decimal CalcularValorInventario()
        {
            throw new NotImplementedException();
        }
    }
}
