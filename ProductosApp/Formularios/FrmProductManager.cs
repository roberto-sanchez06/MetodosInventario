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
using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;

namespace ProductosApp.Formularios
{
    public partial class FrmProductManager : Form
    {
        private IMovimientoService movimientoService;
        private IProdService prodService;
        public FrmProductManager(IMovimientoService movimientoService, IProdService prodService)
        {
            this.prodService=prodService;
            this.movimientoService = movimientoService;
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
                Product p=prodService.GetProductById(int.Parse(txtFinder.Text));
                if(p == null)
                {
                    throw new ArgumentException("Producto no encontrado");
                }
                FrmTransacciones frmTrans = new FrmTransacciones(p, movimientoService, (ValoracionInventario)cmbValoracionInv.SelectedIndex);
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
            FormInventario frmInv = new FormInventario();
            frmInv.movimientoService = movimientoService;
            frmInv.prodService = prodService;
            frmInv.ShowDialog();
            //rtbProductViewer.Text = "";
            //foreach (Product p in prodService.FindAll())
            //{
            //    rtbProductViewer.AppendText(p.Nombre+"\n");
            //}
            rtbProductViewer.Text += movimientoService.FindAll()[prodService.GetLastProductId()-1].Producto.Descripcion;
        }

        private void FrmProductManager_Load(object sender, EventArgs e)
        {
            cmbValoracionInv.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
        }
    }
}
