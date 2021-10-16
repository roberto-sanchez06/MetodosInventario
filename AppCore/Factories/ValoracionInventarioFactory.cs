using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Processses.Inventories;
using Domain.Enums;

namespace AppCore.Factories
{
    public static class ValoracionInventarioFactory
    {
        public static IValoracionInventario CreateInstance(ValoracionInventario val)
        {
            switch (val)
            {
                case ValoracionInventario.PEPS:
                    return new MetodoPEPS();
                case ValoracionInventario.UEPS:
                    return new MetodoUEPS();
                case ValoracionInventario.PromedioPonderado:
                    return new MetodoPromPonderado();
                case ValoracionInventario.PromedioSimple:
                    return new MetodoPromSimple();
                default:
                    throw new ArgumentException("No existe ese metodo");
            }
        }
    }
}
