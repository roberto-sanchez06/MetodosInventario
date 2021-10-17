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
        private IMoviemntoService MovModel;

        public MovimientoService(IMoviemntoService movModel)
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

        public int GetExistencias()
        {
            return MovModel.GetExistencias();
        }

        public Salida[] GetSalidas()
        {
            return MovModel.GetSalidas();
        }

        public int Update(MovAlmacen t)
        {
            return MovModel.Update(t);
        }
    }
}
