using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class ProductService : IProdService
    {

        private IProdModel productoModel;
        public ProductService(IProdModel productoModel)
        {
            this.productoModel = productoModel;
        }
        public void Create(Product t)
        {
            productoModel.Create(t);
        }

        public bool Delete(Product t)
        {
            return productoModel.Delete(t);
        }

        public Product[] FindAll()
        {
            return productoModel.FindAll();
        }

        public int GetLastProductId()
        {
            return productoModel.GetLastProductId();
        }

        public Product GetProductById(int id)
        {
            return productoModel.GetProductById(id);
        }

        public Product[] GetProductsByFechaVencimiento(DateTime fv)
        {
            return productoModel.GetProductsByFechaVencimiento(fv);
        }

        public Product[] GetProductsByUnidadMedida(UnidadMedida um)
        {
            return productoModel.GetProductsByUnidadMedida(um);
        }

        public int Update(Product t)
        {
            return productoModel.Update(t);
        }
    }
}
