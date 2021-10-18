using System;
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
using Domain.Entities;
using Domain.Entities.Productos;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FrmTransacciones : Form
    {
        private Product prod;
        private IMovimientoService mov;
        private ValoracionInventario vi;
        public FrmTransacciones(Product prod, IMovimientoService mov, ValoracionInventario vi)
        {
            this.vi = vi;
            this.prod = prod;
            this.mov = mov;
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada ent = new Entrada((int)nudCantidad.Value, DateTime.Now, prod)
                {
                    Precio = nudPrecio.Value,
                    PrecioTotal = nudPrecio.Value * (int)nudCantidad.Value
                };
                mov.Create(ent);
                rtbInventoryViewer.AppendText(ent.MostrarDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            cmbMovAlmacen.Items.AddRange(Enum.GetValues(typeof(MovimientoAlmacen)).Cast<object>().ToArray());
            //cmbTipoValoracion.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
            foreach (MovAlmacen m in mov.GetMovimientosByProducto(prod))
            {
                rtbInventoryViewer.AppendText(m.MostrarDatos());
            }
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
                Salida s = new Salida((int)nudCantidad.Value,DateTime.Now,prod);
                s.Precio=ValoracionInventarioFactory.CreateInstance(vi).CalcularCostoVenta(ref mov,s);
                s.PrecioTotal = s.Precio * s.Cantidad;
                rtbInventoryViewer.AppendText(s.MostrarDatos());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //private void VerificarSeleccion()
        //{
        //    if (cmbMovAlmacen.SelectedIndex == -1)
        //    {
        //        throw new ArgumentException("No seleccionó nada");
        //    }
        //}
    }
}
