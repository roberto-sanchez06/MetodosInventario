using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Entities.Productos;
using Domain.Enums;

namespace Domain.Interfaces
{
    //TODO creacion de una nueva interfaz para no modificar ProductModel por si trabajamos con el en futuros proyectos
    public interface IProdModel : IModel<Product>
    {
        Product GetProductById(int id);
        Product[] GetProductsByUnidadMedida(UnidadMedida um);
        Product[] GetProductsByFechaVencimiento(DateTime fv);
        int GetLastProductId();
    }
}
