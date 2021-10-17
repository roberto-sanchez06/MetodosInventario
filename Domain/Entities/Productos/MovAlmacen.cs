using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
    public abstract class MovAlmacen
    {
        public Product Producto { get; set; }
        protected MovAlmacen(int cantidad, DateTime fecha, Product product)
        {
            Cantidad = cantidad;
            Fecha = fecha;
            Producto = product;
        }

        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioTotal { get; set; }
        public abstract string MostrarDatos();
        public class MovAlmacenFechaComparer : IComparer<MovAlmacen>
        {
            public int Compare(MovAlmacen x, MovAlmacen y)
            {
                return x.Fecha.CompareTo(y.Fecha);
            }
        }
    }
}
