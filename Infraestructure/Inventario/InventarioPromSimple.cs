using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public class InventarioPromSimple : InventarioBase
    {
        public override decimal CalcularValorSalida(int salida)
        {
            return totalCompras/noCompras;
        }
    }
}
