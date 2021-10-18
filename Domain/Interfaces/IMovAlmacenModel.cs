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
        //obtener todas las entradas
        Entrada[] GetEntradas();
        //obtener todas las salidas
        Salida[] GetSalidas();
        int GetExistencias();
        MovAlmacen[] GetMovimientosByProducto(Product p);
        //obtener entradas de un producto especifico
        Entrada[] GetEntradas(Product p);
        //obtener salidas de un producto especifico
        Salida[] GetSalidas(Product p);
    }
}
