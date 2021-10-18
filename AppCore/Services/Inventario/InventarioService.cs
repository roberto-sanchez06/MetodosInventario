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
            inventarioModel.Add(t);
        }

        public decimal CalcularValorSalida(int salida)
        {
            return inventarioModel.CalcularValorSalida(salida);
        }

        public bool Delete(int i)
        {
            return inventarioModel.Delete(i);
        }

        public Producto[] FindAll()
        {
            return inventarioModel.FindAll();
        }

        public int GetnoCompras()
        {
            return inventarioModel.GetnoCompras();
        }

        public int GetnoSalidas()
        {
            return inventarioModel.GetnoSalidas();
        }

        public decimal GetTotalCompras()
        {
            return inventarioModel.GetTotalCompras();
        }

        public decimal GetTotalValorInventario()
        {
            return inventarioModel.GetTotalValorInventario();
        }

        public decimal GetTotalVentas()
        {
            return inventarioModel.GetTotalVentas();
        }

        public int ObtenerExistencias()
        {
            return inventarioModel.ObtenerExistencias();
        }

        public void Vender(int uni)
        {
            inventarioModel.Vender(uni);
        }
    }
}
