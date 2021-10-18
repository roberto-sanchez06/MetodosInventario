using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;

namespace Infraestructure.Productos
{
    public class ProdModel : IProdModel
    {
        private Product[] Products;

        #region CRUD
        public void Create(Product p)
        {
            Add(p, ref Products);
        }

        public int Update(Product p)
        {
            if (p == null)
            {
                throw new ArgumentException("El Product no puede ser null.");
            }

            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El Product con id {p.Id} no se encuentra.");
            }

            Products[index] = p;
            return index;
        }

        public bool Delete(Product p)
        {
            if (p == null)
            {
                throw new ArgumentException("El Product no puede ser null.");
            }

            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El Product con id {p.Id} no se encuentra.");
            }

            if (index != Products.Length - 1)
            {
                Products[index] = Products[Products.Length - 1];
            }

            Product[] tmp = new Product[Products.Length - 1];
            Array.Copy(Products, tmp, tmp.Length);
            Products = tmp;

            return Products.Length == tmp.Length;
        }
        public Product[] FindAll()
        {
            return Products;
        }

        #endregion

        #region Queries
        public Product GetProductById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }   

            int index = GetIndexById(id);

            return index < 0 ? null : Products[index];
        }

        public Product[] GetProductsByUnidadMedida(UnidadMedida um)
        {
            Product[] tmp = null;
            if (Products == null)
            {
                return tmp;
            }

            foreach (Product p in Products)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Product[] GetProductsByFechaVencimiento(DateTime dt)
        {
            Product[] tmp = null;
            if (Products == null)
            {
                return tmp;
            }

            foreach (Product p in Products)
            {
                if (p.FechaVencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }
        public int GetLastProductId()
        {
            try
            {

                return Products == null ? 0 : Products[Products.Length - 1].Id;
            }
            catch (IndexOutOfRangeException)
            {

                return 0;
            }
        }
        #endregion

        #region Private Method
        private void Add(Product p, ref Product[] pds)
        {
            if (pds == null)
            {
                pds = new Product[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Product[] tmp = new Product[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (Products == null)
            {
                return index;
            }

            foreach (Product p in Products)
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

        #endregion
    }
}
