using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure.Productos
{
    public class MovAlmacenModel : IMoviemntoService
    {
        private MovAlmacen[] movimientos;
        public void Create(MovAlmacen t)
        {
            Add(t, ref movimientos);
        }

        public bool Delete(MovAlmacen t)
        {
            throw new NotImplementedException();
        }

        public MovAlmacen[] FindAll()
        {
            return movimientos;
        }
        //TODO revisar
        public Entrada[] GetEntradas()
        {
            MovAlmacen[] entradas = null;
            foreach(MovAlmacen m in movimientos)
            {
                if(m is Entrada)
                {
                    Add(m, ref entradas);
                }
            }
            return (Entrada[])entradas;
        }

        public Entrada[] GetEntradas(Product p)
        {
            MovAlmacen[] movs = null;
            if (p is null)
            {
                throw new ArgumentNullException("Producto nulo");
            }

            foreach (Entrada m in GetEntradas())
            {
                //TODO revisar aqui
                if (m.Producto.Equals(p))
                {
                    Add(m, ref movs);
                }
            }
            return (Entrada[])movs;
        }

        //TODO: revisar si este metodo debe de ir
        public int GetExistencias()
        {
            int cant = 0;
            foreach(Entrada e in GetEntradas())
            {
                cant += e.Cantidad;
            }
            return cant;
        }

        public MovAlmacen[] GetMovimientosByProducto(Product p)
        {
            MovAlmacen[] movs=null;
            if (p is null)
            {
                throw new ArgumentNullException("PRODUCTO nulo");
            }

            foreach (MovAlmacen m in movimientos)
            {
                //TODO revisar aqui
                if (m.Producto.Equals(p))
                {
                    Add(m, ref movs);
                }
            }
            return movs;
        }

        //TODO revisar
        public Salida[] GetSalidas()
        {
            MovAlmacen[] salidas = null;
            foreach (MovAlmacen m in movimientos)
            {
                if (m is Salida)
                {
                    Add(m, ref salidas);
                }
            }
            return (Salida[])salidas;
        }

        public Salida[] GetSalidas(Product p)
        {
            MovAlmacen[] movs = null;
            if (p is null)
            {
                throw new ArgumentNullException("Producto nulo");
            }

            foreach (Salida m in GetSalidas())
            {
                //TODO revisar aqui
                if (m.Producto.Equals(p))
                {
                    Add(m, ref movs);
                }
            }
            return (Salida[])movs;
        }

        public int Update(MovAlmacen t)
        {
            throw new NotImplementedException();
        }

        private void Add(MovAlmacen mov, ref MovAlmacen[] ma)
        {
            if (ma == null)
            {
                ma = new MovAlmacen[1];
                ma[ma.Length - 1] = mov;
                return;
            }

            MovAlmacen[] tmp = new MovAlmacen[ma.Length + 1];
            Array.Copy(ma, tmp, ma.Length);
            tmp[tmp.Length - 1] = mov;
            ma = tmp;
        }
    }
}
