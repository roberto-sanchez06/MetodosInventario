using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public abstract class ValoracionInventarioBase : IValoracionInventario
    {
        public abstract decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s);

        public decimal CalcularValorExist(MovAlmacen[] mov)
        {
            throw new NotImplementedException();
        }

        public void Vender(ref IMovimientoService ent, int salida)
        {
            //este es el movimiento fisico del inventario, su movimiento es irrelevante salvo para el UEPS
            while (ent.GetEntradas()[0].CantidadDisponible < salida)
            {
                salida -= ent.GetEntradas()[0].CantidadDisponible;
                //aqui no se elimina como tal
                ent.GetEntradas()[0].EntradaVendida = true;
            }
            ent.GetEntradas()[0].CantidadDisponible -= salida;
            if (ent.GetEntradas()[0].CantidadDisponible == 0)
            {
                ent.GetEntradas()[0].EntradaVendida = true;
            }
        }
    }
}
