using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
    public class Salida : MovAlmacen
    {
        public Salida(int cantidad, DateTime fecha, Product prod) : base(cantidad, fecha, prod)
        {
        }

        public override int AfectacionInventario()
        {
            return Cantidad * -1;
        }

        public override string MostrarDatos()
        {
            return string.Format("{0,15:d} {1,20:d} {2,20:f} {3,20:f}\n", Fecha, Cantidad, Precio, PrecioTotal);
        }
    }
}
