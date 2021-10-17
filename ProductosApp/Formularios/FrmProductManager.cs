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
using AppCore.Services;
using Domain.Entities;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FrmProductManager : Form
    {
        private IProductoService prodService;
        public FrmProductManager(IProductoService productoService)
        {
            this.prodService = productoService;
            InitializeComponent();
        }
        private void txtFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se puede colocar numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnManejarInv_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbValoracionInv.SelectedIndex == -1)
                {
                    throw new ArgumentException("No selecciono ningun metodo");
                }
                Producto prod=prodService.GetProductoById(int.Parse(txtFinder.Text));
                new FrmTransacciones(prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PModel = prodService;
            frmProducto.ShowDialog();
            rtbProductViewer.Text = "";
            foreach (Producto p in prodService.FindAll())
            {
                rtbProductViewer.AppendText(p.MostrarDatos());
            }
            //rtbProductViewer.Text=(prodService.GetType().ToString());
            //Type t= prodService.GetType();
        }

        private void FrmProductManager_Load(object sender, EventArgs e)
        {
            cmbValoracionInv.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
        }
    }
}
