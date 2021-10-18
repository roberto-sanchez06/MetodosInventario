
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbMovAlmacen = new System.Windows.Forms.ComboBox();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.pnlCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbInventoryViewer
            // 
            this.rtbInventoryViewer.Location = new System.Drawing.Point(12, 60);
            this.rtbInventoryViewer.Name = "rtbInventoryViewer";
            this.rtbInventoryViewer.ReadOnly = true;
            this.rtbInventoryViewer.Size = new System.Drawing.Size(776, 345);
            this.rtbInventoryViewer.TabIndex = 0;
            this.rtbInventoryViewer.Text = "";
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(152, 26);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(111, 23);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "Registrar Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(676, 418);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(567, 23);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(103, 23);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Registrar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Visible = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(253, 26);
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
            // cmbMovAlmacen
            // 
            this.cmbMovAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovAlmacen.FormattingEnabled = true;
            this.cmbMovAlmacen.Location = new System.Drawing.Point(12, 25);
            this.cmbMovAlmacen.Name = "cmbMovAlmacen";
            this.cmbMovAlmacen.Size = new System.Drawing.Size(215, 21);
            this.cmbMovAlmacen.TabIndex = 5;
            this.cmbMovAlmacen.SelectedIndexChanged += new System.EventHandler(this.cmbMovAlmacen_SelectedIndexChanged);
            // 
            // pnlCompra
            // 
            this.pnlCompra.Controls.Add(this.lblPrecio);
            this.pnlCompra.Controls.Add(this.nudPrecio);
            this.pnlCompra.Controls.Add(this.btnCompra);
            this.pnlCompra.Location = new System.Drawing.Point(410, 0);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(270, 54);
            this.pnlCompra.TabIndex = 6;
            this.pnlCompra.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(48, 10);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(7, 26);
            this.nudPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 0;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(289, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // FrmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pnlCompra);
            this.Controls.Add(this.cmbMovAlmacen);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.rtbInventoryViewer);
            this.Name = "FrmTransacciones";
            this.Text = "FrmTransacciones";
            this.Load += new System.EventHandler(this.FrmTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInventoryViewer;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbMovAlmacen;
        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblCantidad;
    }
}