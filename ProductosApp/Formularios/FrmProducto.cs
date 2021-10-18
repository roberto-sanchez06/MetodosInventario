using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{    
    public partial class FrmProducto : Form
    {
        public IProductoService PModel { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDesc.Text) || cmbMeasureUnit.SelectedIndex == -1)
            {
                MessageBox.Show("hay algun campo vacio porfavor llenelo");

            }
            else
            {
                Producto p = new Producto()
                {
                    Id = PModel.GetLastProductoId() + 1,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDesc.Text,
                    Existencia = (int)nudExist.Value,
                    Precio = nudPrice.Value,
                    FechaVencimiento = dtpCaducity.Value,
                    UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectedIndex,
                    //registro la fecha de adquisicion en tiempo real
                    FechaAdquisicion = DateTime.Now
                };
                PModel.Create(p);
                Dispose();
            }
        }
    }
}
