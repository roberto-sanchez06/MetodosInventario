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
using Domain.Entities.Productos;
using Domain.Enums;

namespace ProductosApp.Formularios
{
    public partial class FormInventario : Form
    {
        public IMovimientoService movimientoService { get; set; }
        public IProdService prodService { get; set; }
        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text)|| string.IsNullOrEmpty(txtDesc.Text)|| cmbMeasureUnit.SelectedIndex == -1)
            {


                MessageBox.Show("hay campos vacios");



            }
            else
            {
                Product p = new Product()
                {
                    Id = prodService.GetLastProductId() + 1,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDesc.Text,
                    FechaVencimiento = dtpCaducity.Value,
                    UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectedIndex
                };
                Entrada ent = new Entrada((int)nudExist.Value, DateTime.Now, p)
                {
                    Precio = nudPrice.Value,
                    PrecioTotal = nudPrice.Value * (int)nudExist.Value
                };
                prodService.Create(p);
                movimientoService.Create(ent);
                Dispose();
            }
            
            
            
           
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>()
                                              .ToArray()
                                          );
        }
    }
}
