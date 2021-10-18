using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoPromSimple : ValoracionInventarioBase
    {
        public decimal CalcularCostoVenta(ref Entrada[] ent, Salida s)
        {
            decimal costo = 0M;
            foreach(Entrada e in ent)
            {
                costo += e.Precio;
            }
            return costo / ent.Length ;
        }

        public override decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s)
        {
            throw new NotImplementedException();
        }
    }
}
