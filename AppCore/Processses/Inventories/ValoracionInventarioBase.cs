using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Factories;
using AppCore.Interfaces;
using Domain.Entities.Productos;

namespace AppCore.Processses.Inventories
{
    public abstract class ValoracionInventarioBase : IValoracionInventario
    {
        public abstract decimal CalcularCostoVenta(ref IMovimientoService ent, Salida s);

        public decimal CalcularValorExist(MovAlmacen[] mov)
        {
            decimal valor = 0M;
            foreach (MovAlmacen m in mov)
            {
                valor+=DebeHaberFactory.CreateInstance(m).CalcularDebeHaber(m);
            }
            return valor;
        }

        public void Vender(ref IMovimientoService ent, Salida salida)
        {
            int i = 0;
            while (ent.GetEntradas(salida.Producto)[i].EntradaVendida == true)
            {
                i++;
            }
            //este es el movimiento fisico del inventario, su movimiento es irrelevante salvo para el UEPS
            while (ent.GetEntradas(salida.Producto)[i].CantidadDisponible < salida.Cantidad)
            {
                //se podria poner salida.cantidad en una variable
                salida.Cantidad -= ent.GetEntradas(salida.Producto)[i].CantidadDisponible;
                //aqui no se elimina como tal
                Entrada entrada=ent.GetEntradas(salida.Producto)[i];
                entrada.EntradaVendida = true;
                Entrada en = (Entrada)ent.MovimientoById(entrada.Id);
                
                i++;
            }
            ent.GetEntradas(salida.Producto)[i].CantidadDisponible -= salida.Cantidad;
            if (ent.GetEntradas(salida.Producto)[i].CantidadDisponible == 0)
            {
                ent.GetEntradas(salida.Producto)[i].EntradaVendida = true;
                i++;
            }
        }
    }
}
