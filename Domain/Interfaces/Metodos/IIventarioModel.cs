using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interfaces.Metodos
{
    public interface IIventarioModel : ICreateDeleteModel<Producto>
    {
        void Vender(int uni);
        decimal CalcularValorSalida(int salida);
        decimal GetTotalValorInventario();
        int ObtenerExistencias();
        int GetnoCompras();
        int GetnoSalidas();
        decimal GetTotalCompras();
        decimal GetTotalVentas();
    }
}
