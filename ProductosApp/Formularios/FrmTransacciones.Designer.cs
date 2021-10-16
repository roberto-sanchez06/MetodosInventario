
namespace ProductosApp.Formularios
{
    partial class FrmTransacciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbInventoryViewer = new System.Windows.Forms.RichTextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnVerInv = new System.Windows.Forms.Button();
            this.cmbTipoValoracion = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbInventoryViewer
            // 
            this.rtbInventoryViewer.Location = new System.Drawing.Point(12, 38);
            this.rtbInventoryViewer.Name = "rtbInventoryViewer";
            this.rtbInventoryViewer.ReadOnly = true;
            this.rtbInventoryViewer.Size = new System.Drawing.Size(776, 367);
            this.rtbInventoryViewer.TabIndex = 0;
            this.rtbInventoryViewer.Text = "";
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(3, 3);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(111, 23);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "Registrar Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCompra);
            this.flowLayoutPanel1.Controls.Add(this.btnVerInv);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(551, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(493, 9);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(103, 23);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Registrar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnVerInv
            // 
            this.btnVerInv.Location = new System.Drawing.Point(120, 3);
            this.btnVerInv.Name = "btnVerInv";
            this.btnVerInv.Size = new System.Drawing.Size(112, 23);
            this.btnVerInv.TabIndex = 3;
            this.btnVerInv.Text = "Ver inventario";
            this.btnVerInv.UseVisualStyleBackColor = true;
            this.btnVerInv.Click += new System.EventHandler(this.btnVerInv_Click);
            // 
            // cmbTipoValoracion
            // 
            this.cmbTipoValoracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoValoracion.FormattingEnabled = true;
            this.cmbTipoValoracion.Location = new System.Drawing.Point(12, 9);
            this.cmbTipoValoracion.Name = "cmbTipoValoracion";
            this.cmbTipoValoracion.Size = new System.Drawing.Size(267, 21);
            this.cmbTipoValoracion.TabIndex = 3;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(321, 9);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cmbTipoValoracion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.rtbInventoryViewer);
            this.Name = "FrmTransacciones";
            this.Text = "FrmTransacciones";
            this.Load += new System.EventHandler(this.FrmTransacciones_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInventoryViewer;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnVerInv;
        private System.Windows.Forms.ComboBox cmbTipoValoracion;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}