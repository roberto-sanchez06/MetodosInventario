﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Factories;
using AppCore.Interfaces;
using AppCore.Interfaces.Inventario;
using AppCore.Services.Inventario;
using Domain.Entities;
using Domain.Entities.Productos;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FrmTransacciones : Form
    {
        private InventarioService inventario;
        private Producto p;
        private int i;
        public FrmTransacciones(InventarioService inventario, Producto p, int i)
        {
            InitializeComponent();
            this.inventario = inventario;
            this.p = p;
            this.i = i;
            inventario.Add(p);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    FechaVencimiento = p.FechaVencimiento,
                    UnidadMedida = p.UnidadMedida,
                    Existencia = (int)nudCantidad.Value,
                    Precio=nudPrecio.Value,
                    //la fecha es en tiempo real
                    FechaAdquisicion=DateTime.Now
                };
                inventario.Add(prod);
                rtbInventoryViewer.AppendText("(Nueva entrada): "+prod.MostrarDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            rtbInventoryViewer.Text = i.ToString();
            cmbMovAlmacen.Items.AddRange(Enum.GetValues(typeof(MovimientoAlmacen)).Cast<object>().ToArray());
            //cmbTipoValoracion.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
            rtbInventoryViewer.Text += string.Format("{0,33:d} {1,20:d} {2,22: d} {3,20:f} {4,20:f} \n",
                                "Id", "Fecha", "Cant", "Costo Uni", "Costo Total");
            rtbInventoryViewer.Text += "(Inventario Inicial): ";
            foreach (Producto p in inventario.FindAll())
            {
                rtbInventoryViewer.AppendText(p.MostrarDatos());
            }
            //rtbInventoryViewer.AppendText("\t"+ValoracionInventarioFactory.CreateInstance(vi).CalcularValorExist(mov.GetMovimientosByProducto(prod)).ToString()+"\n");
        }

        private void cmbMovAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMovAlmacen.SelectedIndex)
            {
                case 0:
                    btnVenta.Visible = false;
                    pnlCompra.Visible=true;
                    break;
                case 1:
                    btnVenta.Visible = true;
                    pnlCompra.Visible = false;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            //try
            //{
            int salida = (int)nudCantidad.Value;
            decimal precio = inventario.CalcularValorSalida(salida);
            rtbInventoryViewer.AppendText("(Nueva salida): "+string.Format("{0,-3:d} {1,20:d} {2,10: d} {3,20:f} {4,20:f} \n",
                            $"{p.Id}", $"{DateTime.Now}", $"{salida}", $"{precio}", $"{ precio * salida }"));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
