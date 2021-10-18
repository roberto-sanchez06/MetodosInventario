using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;

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
            // me daba un error si no hacia eso
            string s = JsonConvert.SerializeObject(entradas);
            Entrada[] ent = JsonConvert.DeserializeObject<List<Entrada>>(s).ToArray();
            return ent;
        }

        public Entrada[] GetEntradas(Product p)
        {
            MovAlmacen[] movs = null;
            if (p is null)
            {
                throw new ArgumentNullException("Producto nulo");
            }
            //string s = JsonConvert.SerializeObject(p);
            //Product pr = JsonConvert.DeserializeObject<Product>(s);
            foreach (Entrada m in GetEntradas())
            {
                //TODO revisar aqui
                //no me entraba al if si ponia con el metodo equals
                if (m.Producto.Id==p.Id && m.Producto.Nombre == p.Nombre && m.Producto.Descripcion ==p.Descripcion
                    && m.Producto.FechaVencimiento ==p.FechaVencimiento && m.Producto.UnidadMedida ==p.UnidadMedida)
                {
                    Add(m, ref movs);
                }
            }
            string st = JsonConvert.SerializeObject(movs);
            Entrada[] ent = JsonConvert.DeserializeObject<List<Entrada>>(st).ToArray();
            return ent;
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
