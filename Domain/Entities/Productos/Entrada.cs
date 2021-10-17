using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
    public class Entrada : MovAlmacen
    {
        public bool EntradaVendida { get; set; }
        public int CantidadDisponible { get; set; }
        public Entrada(int cantidad, DateTime fecha, Product prod) : base(cantidad, fecha, prod)
        {
            EntradaVendida = false;
            CantidadDisponible = cantidad;
        }

        public override string MostrarDatos()
        {
            return string.Format("{0,-5:d} {1,20:d} {2,20:f} {3,20:f}\n",Fecha, Cantidad, Precio, PrecioTotal);
        }
    }
}
