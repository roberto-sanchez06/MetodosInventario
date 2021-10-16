using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FrmTransacciones : Form
    {
        public FrmTransacciones()
        {
            InitializeComponent();
        }

        private void btnVerInv_Click(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            cmbTipoValoracion.Items.AddRange(Enum.GetValues(typeof(ValoracionInventario)).Cast<object>().ToArray());
        }
    }
}
