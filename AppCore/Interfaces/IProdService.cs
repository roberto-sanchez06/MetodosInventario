using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Enums;

namespace AppCore.Interfaces
{
    public interface IProdService : IService<Product>
    {
        Product GetProductById(int id);
        Product[] GetProductsByUnidadMedida(UnidadMedida um);
        Product[] GetProductsByFechaVencimiento(DateTime fv);
        int GetLastProductId();
    }
}
