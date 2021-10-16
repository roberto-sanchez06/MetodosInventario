using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IValoracionInventario
    {
        decimal CalcularCostoVenta();
        decimal CalcularValorInventario();
    }
}
