using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoPromSimple : ValoracionInventarioBase
    {
        public override decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s)
        {
            decimal costo = 0M;
            foreach (Entrada e in ent.GetEntradas(s.Producto))
            {
                costo += e.Precio;
            }
            Vender(ref ent, s);
            return costo / ent.GetEntradas(s.Producto).Length;
        }
    }
}
