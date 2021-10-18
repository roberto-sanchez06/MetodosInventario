
namespace ProductosApp.Formularios
{
    partial class FormInventario
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
            this.lblUniMedida = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.lblCostoUni = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudExist = new System.Windows.Forms.NumericUpDown();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUniMedida
            // 
            this.lblUniMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUniMedida.AutoSize = true;
            this.lblUniMedida.Location = new System.Drawing.Point(16, 245);
            this.lblUniMedida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUniMedida.Name = "lblUniMedida";
            this.lblUniMedida.Size = new System.Drawing.Size(159, 13);
            this.lblUniMedida.TabIndex = 23;
            this.lblUniMedida.Text = "Unidad de Medida del producto:";
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Location = new System.Drawing.Point(16, 215);
            this.lblCaducidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(123, 13);
            this.lblCaducidad.TabIndex = 22;
            this.lblCaducidad.Text = "Caducidad del producto:";
            // 
            // lblCostoUni
            // 
            this.lblCostoUni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCostoUni.AutoSize = true;
            this.lblCostoUni.Location = new System.Drawing.Point(16, 178);
            this.lblCostoUni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoUni.Name = "lblCostoUni";
            this.lblCostoUni.Size = new System.Drawing.Size(74, 13);
            this.lblCostoUni.TabIndex = 21;
            this.lblCostoUni.Text = "Costo unitario:";
            this.lblCostoUni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUnidades
            // 
            this.lblUnidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(15, 144);
            this.lblUnidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(113, 13);
            this.lblUnidades.TabIndex = 20;
            this.lblUnidades.Text = "Unidades compradas :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 65);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(128, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion del producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 33);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre del producto:";
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(182, 243);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(202, 21);
            this.cmbMeasureUnit.TabIndex = 17;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCaducity.Location = new System.Drawing.Point(182, 211);
            this.dtpCaducity.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(202, 20);
            this.dtpCaducity.TabIndex = 16;
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(182, 176);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(201, 20);
            this.nudPrice.TabIndex = 15;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudExist
            // 
            this.nudExist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudExist.Location = new System.Drawing.Point(182, 142);
            this.nudExist.Margin = new System.Windows.Forms.Padding(2);
            this.nudExist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExist.Name = "nudExist";
            this.nudExist.Size = new System.Drawing.Size(201, 20);
            this.nudExist.TabIndex = 14;
            this.nudExist.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(182, 63);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(202, 67);
            this.txtDesc.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(182, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(323, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblUniMedida);
            this.groupBox1.Controls.Add(this.nudExist);
            this.groupBox1.Controls.Add(this.lblCaducidad);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.lblCostoUni);
            this.groupBox1.Controls.Add(this.dtpCaducity);
            this.groupBox1.Controls.Add(this.lblUnidades);
            this.groupBox1.Controls.Add(this.cmbMeasureUnit);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 308);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Compra";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FormInventario";
            this.Text = "FormInvemtaio";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUniMedida;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label lblCostoUni;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudExist;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}