using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public class MetodoUEPS : ValoracionInventarioBase
    {
        public override decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s)
        {
            throw new NotImplementedException();
        }
    }
}
