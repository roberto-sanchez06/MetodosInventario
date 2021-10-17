using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FrmTransacciones : Form
    {
        private IProductoService productoService;
        private Producto p;
        public FrmTransacciones(Producto p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                
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
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
