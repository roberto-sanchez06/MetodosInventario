using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;

namespace Infraestructure.Productos
{
    public class MovAlmacenModel : IMovAlmacenModel
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
                if (m.Producto.Id == p.Id && m.Producto.Nombre == p.Nombre && m.Producto.Descripcion == p.Descripcion
                    && m.Producto.FechaVencimiento == p.FechaVencimiento && m.Producto.UnidadMedida == p.UnidadMedida)
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
            if (salidas != null)
            {
                string s = JsonConvert.SerializeObject(salidas);
                Salida[] sal = JsonConvert.DeserializeObject<List<Salida>>(s).ToArray();
                return sal;
            }
            else
            {
                return null;
            }
        }

        public Salida[] GetSalidas(Product p)
        {
            MovAlmacen[] salidas = null;
            if (p is null)
            {
                throw new ArgumentNullException("Producto nulo");
            }
            if (GetSalidas() == null)
            {
                return null;
            }
            foreach (Salida m in GetSalidas())
            {
                //TODO revisar aqui
                //da error con equal
                if (m.Producto.Id == p.Id && m.Producto.Nombre == p.Nombre && m.Producto.Descripcion == p.Descripcion
                    && m.Producto.FechaVencimiento == p.FechaVencimiento && m.Producto.UnidadMedida == p.UnidadMedida)
                {
                    Add(m, ref salidas);
                }
            }
            string s = JsonConvert.SerializeObject(salidas);
            Salida[] sal = JsonConvert.DeserializeObject<List<Salida>>(s).ToArray();
            return sal;
        }

        public MovAlmacen MovimientoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }

            int index = GetIndexById(id);

            return index < 0 ? null : movimientos[index];
        }
        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (movimientos == null)
            {
                return index;
            }

            foreach (MovAlmacen p in movimientos)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
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

        public int GetLastIdMov()
        {
            try
            {

                return movimientos == null ? 0 : movimientos[movimientos.Length - 1].Id;
            }
            catch (IndexOutOfRangeException)
            {

                return 0;
            }
        }
    }
}
