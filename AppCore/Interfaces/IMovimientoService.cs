using Domain.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IMovimientoService: IService<MovAlmacen>
    {
        Entrada[] GetEntradas();
        Salida[] GetSalidas();
        int GetExistencias();
    }
}
