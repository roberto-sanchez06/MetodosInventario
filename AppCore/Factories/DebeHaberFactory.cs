using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Processses.DebeHaber;
using Domain.Entities.Productos;

namespace AppCore.Factories
{
    public static class DebeHaberFactory
    {
        //TODO: El factory se podria omitir pero lo voy a dejar para que la clase movAlmacen no tenga dos responsabilidades
        public static  ICalcularDebeHaber CreateInstance(MovAlmacen m)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (m is Entrada)
            {
                return new EntradaDebeHaber();
            }
            else if (m is Salida)
            {
                return new SalidaDebeHaber();
            }
            else
            {
                throw new Exception(nameof(m));
            }
        }
    }
}
