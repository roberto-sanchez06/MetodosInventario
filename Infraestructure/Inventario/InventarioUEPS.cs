using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public class InventarioUEPS : InventarioBase
    {
        public override decimal CalcularValorSalida(int salida)
        {
            if (productos == null)
            {
                throw new ArgumentException("NO hay productos para calcular el inventario");
            }
            if (salida > productos[productos.Length-1].Existencia)
            {
                throw new ArgumentException("Divida la venta");
            }
            decimal valor = productos[productos.Length - 1].Precio;
            valorInventario -= valor * salida;
            totalVentas += valor;
            Vender(salida);
            return valor;
        }
        public override void Vender(int salida)
        {
            while (productos[productos.Length-1].Existencia < salida)
            {
                salida -= productos[productos.Length - 1].Existencia;
                Delete(productos[productos.Length-1]);
            }
            productos[productos.Length - 1].Existencia -= salida;
            if (productos[productos.Length - 1].Existencia == 0)
            {
                Delete(productos[productos.Length - 1]);
            }
        }
    }
}
