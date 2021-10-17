using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public abstract class ValoracionInventarioBase : IValoracionInventario
    {
        public abstract decimal CalcularCostoVenta(ref Entrada[] ent, Salida s);

        public decimal CalcularValorExist(MovAlmacen[] mov)
        {
            throw new NotImplementedException();
        }

        public void Vender(ref Entrada[] ent, int salida)
        {
            //este es el movimiento fisico del inventario, su movimiento es irrelevante salvo para el UEPS
            while (ent[0].CantidadDisponible < salida)
            {
                salida -= ent[0].CantidadDisponible;
                //aqui no se elimina como tal
                ent[0].EntradaVendida = true;
            }
            ent[0].CantidadDisponible -= salida;
            if (ent[0].CantidadDisponible == 0)
            {
                ent[0].EntradaVendida = true;
            }
        }
    }
}
