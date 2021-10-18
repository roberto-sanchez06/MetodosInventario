using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Services;

namespace AppCore.Factories
{
    public static class InventarioServiceFactory
    {
        public static IMovimientoService CreateInstance(IMovimientoService m)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (m is MovimientoService)
            {
                return null;
            }
            else
            {
                throw new Exception(nameof(m));
            }
        }
    }
}
