using AppCore.Interfaces;
using Domain.Entities.Productos;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class MovimientoService : IMovimientoService
    {
        private IMovAlmacenModel MovModel;

        public MovimientoService(IMovAlmacenModel movModel)
        {
            MovModel = movModel;
        }

        public void Create(MovAlmacen t)
        {
            MovModel.Create(t);
        }

        public bool Delete(MovAlmacen t)
        {
            return MovModel.Delete(t);
            
        }

        public MovAlmacen[] FindAll()
        {
            return MovModel.FindAll();
        }

        public Entrada[] GetEntradas()
        {
            return MovModel.GetEntradas();
        }

        public Entrada[] GetEntradas(Product p)
        {
            return MovModel.GetEntradas(p);
        }

        public int GetExistencias()
        {
            return MovModel.GetExistencias();
        }

        public int GetLastIdMov()
        {
            return MovModel.GetLastIdMov();
        }

        public MovAlmacen[] GetMovimientosByProducto(Product p)
        {
            return MovModel.GetMovimientosByProducto(p);
        }

        public Salida[] GetSalidas()
        {
            return MovModel.GetSalidas();
        }

        public Salida[] GetSalidas(Product p)
        {
            return MovModel.GetSalidas(p);
        }

        public MovAlmacen MovimientoById(int id)
        {
            return MovModel.MovimientoById(id);
        }

        public int Update(MovAlmacen t)
        {
            return MovModel.Update(t);
        }
    }
}
