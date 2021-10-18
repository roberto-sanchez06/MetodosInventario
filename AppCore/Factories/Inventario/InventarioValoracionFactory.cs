using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.Interfaces.Metodos;
using Infraestructure.Inventario;

namespace AppCore.Factories.Inventario
{
    public static class InventarioValoracionFactory
    {
        public static IIventarioModel CreateInstance(ValoracionInventario val)
        {
            switch (val)
            {
                case ValoracionInventario.PEPS:
                    return new InventarioPEPS();
                case ValoracionInventario.UEPS:
                    return new InventarioUEPS();
                case ValoracionInventario.PromedioPonderado:
                    return new InventarioPromPonderado();
                case ValoracionInventario.PromedioSimple:
                    return new InventarioPromSimple();
                default:
                    throw new ArgumentException("No existe ese metodo");
            }
        }
    }
}
