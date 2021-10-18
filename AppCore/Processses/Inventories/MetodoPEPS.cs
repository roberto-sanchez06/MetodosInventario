using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoPEPS : ValoracionInventarioBase
    {
        public override decimal CalcularCostoVenta(ref IMovimientoService en, Salida s)
        {
            if (s is null)
            {
                throw new ArgumentNullException("Salida nula");
            }
            decimal valor = en.GetEntradas()[0].Precio;
            Vender(ref en, s.Cantidad);
            return valor;
        }
    }
}
