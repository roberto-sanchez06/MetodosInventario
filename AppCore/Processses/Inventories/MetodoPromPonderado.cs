using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoPromPonderado : ValoracionInventarioBase
    {
        public override decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s)
        {
            decimal saldo = 0;
            int unidades = 0;
            foreach(Entrada e in ent.GetEntradas(s.Producto))
            {
                saldo = saldo + e.PrecioTotal;
                unidades = unidades + e.CantidadDisponible;
            }
            return saldo / unidades;

        }

       

       

      
    }
}
