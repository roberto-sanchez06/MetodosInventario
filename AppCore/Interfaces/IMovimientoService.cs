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
        MovAlmacen[] GetMovimientosByProducto(Product p);
        //obtener entradas de un producto especifico
        Entrada[] GetEntradas(Product p);
        //obtener salidas de un producto especifico
        Salida[] GetSalidas(Product p);
    }
}
