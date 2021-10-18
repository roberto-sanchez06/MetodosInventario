using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    //TODO clase modificada
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        //agregado
        public DateTime FechaAdquisicion { get; set; }

        public class ProductoOrderByPrecio : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if(x.Precio < y.Precio)
                {
                    return -1;
                }else if(x.Precio > y.Precio)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class ProductoCompareFechaAdq : IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                return x.FechaAdquisicion.CompareTo(y.FechaAdquisicion);
            }
        }
        public string MostrarDatos()
        {
            return string.Format("{0,-5:d} {1,20:d} {2,10: d} {3,20:f} {4,20:f} \n",
                            $"{Id}", $"{FechaAdquisicion}", $"{Existencia}", $"{Precio}", $"{ Precio * Existencia }");
        }
        //public string MostrarDatos()
        //{
        //    return string.Format("{0,-5:d} {1,20} {2, 20:d} {3, 20:d}\n", Id, Nombre, FechaVencimiento, UnidadMedida);
        //}
    }
}
