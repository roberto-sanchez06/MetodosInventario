using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces.Metodos;

namespace Infraestructure.Inventario
{
    public abstract class InventarioBase : IIventarioModel
    {
        protected Producto[] productos;
        protected int existencias=0;
        protected decimal valorInventario=0;
        protected int noCompras=0;
        protected int noSalidas=0;
        protected decimal totalCompras=0;
        protected decimal totalVentas=0;
        public void Add(Producto t)
        {
            existencias += t.Existencia;
            valorInventario += t.Existencia * t.Precio;
            //revisar estas linea
            noCompras++;
            totalCompras += t.Precio;
            if (productos == null)
            {
                productos = new Producto[1];
                productos[productos.Length - 1] = t;
                return;
            }

            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = t;
            productos = tmp;
        }

        public int ObtenerExistencias()
        {
            return existencias;
        }

        public abstract decimal CalcularValorSalida(int salida);

        //revisar delete 
        public bool Delete(int indice)
        {
            if (indice<0)
            {
                throw new ArgumentException("El indice es incorrecto");
            }
            if(productos == null)
            {
                throw new ArgumentException("No hay productos");
            }
            ////int index = GetIndexById(p.Id);
            //int index = int.MinValue, i = 0;
            //foreach (Producto p in productos)
            //{
            //    //ver esta linea de codigo
            //    if (p.Equals(t))
            //    {
            //        index = i;
            //        break;
            //    }
            //    i++;
            //}
            //if (index < 0)
            //{
            //    throw new Exception($"El producto no existe.");
            //}

            if (indice != productos.Length - 1)
            {
                productos[indice] = productos[productos.Length - 1];
            }

            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }

        public decimal GetTotalValorInventario()
        {
            return valorInventario;
        }
        public virtual void Vender(int salida)
        {
            noSalidas++;
            existencias -= salida;
            while (productos[0].Existencia < salida)
            {
                salida -= productos[0].Existencia;
                Delete(0);
                Array.Sort(productos, new Producto.ProductoCompareFechaAdq());
            }
            productos[0].Existencia -= salida;
            if (productos[0].Existencia == 0)
            {
                Delete(0);
                Array.Sort(productos, new Producto.ProductoCompareFechaAdq());
            }
        }

        public int GetnoCompras()
        {
            return noCompras;
        }

        public int GetnoSalidas()
        {
            return noSalidas;
        }

        public decimal GetTotalCompras()
        {
            return totalCompras;
        }

        public decimal GetTotalVentas()
        {
            return totalVentas;
        }

        public Producto[] FindAll()
        {
            return productos;
        }
    }
}
