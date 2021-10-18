using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Inventario
{
    public class InventarioPromPonderado : InventarioBase
    {
        public override decimal CalcularValorSalida(int salida)
        {
            decimal valor = GetTotalValorInventario() / ObtenerExistencias();
            Vender(salida);
            //verficar si esta linea es correcta
            valorInventario -= valor * salida;
            totalVentas += valor;
            return valor;
        }
    }
}
