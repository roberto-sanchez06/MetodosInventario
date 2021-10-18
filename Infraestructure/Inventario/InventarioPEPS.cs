using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public class InventarioPEPS : InventarioBase
    {
        public override decimal CalcularValorSalida(int salida)
        {
            if (productos== null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos[0].Existencia)
            {
                throw new ArgumentException("Para evitar problemas divida las compras");
            }
            decimal valor = productos[0].Precio;
            Vender(salida);
            valorInventario -= valor * salida;
            totalVentas += valor;
            return valor;
        }
    }
}
