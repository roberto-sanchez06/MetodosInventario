using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces.Inventario;
using Domain.Entities;
using Domain.Interfaces.Metodos;

namespace AppCore.Services.Inventario
{
    public class InventarioService : IInventarioService
    {
        private IIventarioModel inventarioModel;

        public InventarioService(IIventarioModel inventarioModel)
        {
            this.inventarioModel = inventarioModel;
        }

        public void Add(Producto t)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularValorSalida(int salida)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Producto t)
        {
            throw new NotImplementedException();
        }

        public int GetnoCompras()
        {
            throw new NotImplementedException();
        }

        public int GetnoSalidas()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalCompras()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalValorInventario()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalVentas()
        {
            throw new NotImplementedException();
        }

        public int ObtenerExistencias()
        {
            throw new NotImplementedException();
        }

        public void Vender(int uni)
        {
            throw new NotImplementedException();
        }
    }
}
