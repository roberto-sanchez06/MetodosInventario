using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Enums;

namespace Domain.Interfaces
{
    //TODO ver si ocupa todos los metodo de IModel
    public interface IMoviemntoService : IModel<MovAlmacen>
    {
        Entrada[] GetEntradas();
        Salida[] GetSalidas();
        int GetExistencias();
    }
}
