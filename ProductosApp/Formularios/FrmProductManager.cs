using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Factories.Inventario;
using AppCore.Interfaces;
using AppCore.Services;
using AppCore.Services.Inventario;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;

namespace ProductosApp.Formularios
{
    public partial class FrmProductManager : Form
    {
        private IProductoService productoService;
        public FrmProductManager(IProductoService productoService)
        {
            InitializeComponent();
            this.productoService = productoService;
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
                Producto p = productoService.GetProductoById(int.Parse(txtFinder.Text));
                if (p == null)
                {
                    throw new ArgumentException("Producto no encontrado");
                }
                FrmTransacciones frmTrans = new FrmTransacciones(new InventarioService(InventarioValoracionFactory.CreateInstance((ValoracionInventario)cmbValoracionInv.SelectedIndex)), p);
                //frmTrans.prod = p;
                //frmTrans.mov = movimientoService;
                frmTrans.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto= new FrmProducto();
            frmProducto.PModel = productoService;
            frmProducto.ShowDialog();
            rtbProductViewer.Text = "Mostrando datos de los productos a valorar, los cuales sirven de inventario inicial\n";
            rtbProductViewer.AppendText(productoService.GetProductosAsJson());
        }

        private void FrmProductManager_Load(object sender, EventArgs e)
        {
            cmbValoracionInv.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
        }
    }
}
