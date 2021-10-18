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
                unidades = unidades + e.CantidadDisponible;
                if (unidades ==0)
                {
                    throw new ArgumentException("Existencias agotadas");
                }
                //redefinir en las clases de movimiento
                saldo = saldo + e.PrecioTotal;
            }
            if (ent.GetSalidas(s.Producto) != null)
            {
                foreach (Salida sal in ent.GetSalidas(s.Producto))
                {
                    unidades -= sal.Cantidad;
                    saldo -= sal.PrecioTotal;
                }
            }
            
            return saldo / unidades;

        }
    }
}
