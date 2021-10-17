﻿
namespace ProductosApp.Formularios
{
    partial class FrmProductManager
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
            this.rtbProductViewer = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnManejarInv = new System.Windows.Forms.Button();
            this.cmbValoracionInv = new System.Windows.Forms.ComboBox();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbProductViewer
            // 
            this.rtbProductViewer.Location = new System.Drawing.Point(12, 51);
            this.rtbProductViewer.Name = "rtbProductViewer";
            this.rtbProductViewer.ReadOnly = true;
            this.rtbProductViewer.Size = new System.Drawing.Size(776, 307);
            this.rtbProductViewer.TabIndex = 0;
            this.rtbProductViewer.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(655, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Añadir nuevo producto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnManejarInv
            // 
            this.btnManejarInv.Location = new System.Drawing.Point(482, 14);
            this.btnManejarInv.Name = "btnManejarInv";
            this.btnManejarInv.Size = new System.Drawing.Size(124, 23);
            this.btnManejarInv.TabIndex = 2;
            this.btnManejarInv.Text = "Aplicar Valoracion Inventario";
            this.btnManejarInv.UseVisualStyleBackColor = true;
            this.btnManejarInv.Click += new System.EventHandler(this.btnManejarInv_Click);
            // 
            // cmbValoracionInv
            // 
            this.cmbValoracionInv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValoracionInv.FormattingEnabled = true;
            this.cmbValoracionInv.Location = new System.Drawing.Point(12, 14);
            this.cmbValoracionInv.Name = "cmbValoracionInv";
            this.cmbValoracionInv.Size = new System.Drawing.Size(268, 21);
            this.cmbValoracionInv.TabIndex = 3;
            // 
            // txtFinder
            // 
            this.txtFinder.Location = new System.Drawing.Point(318, 15);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(125, 20);
            this.txtFinder.TabIndex = 4;
            this.txtFinder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinder_KeyPress);
            // 
            // FrmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.txtFinder);
            this.Controls.Add(this.cmbValoracionInv);
            this.Controls.Add(this.btnManejarInv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbProductViewer);
            this.Name = "FrmProductManager";
            this.Text = "FrmProductManager";
            this.Load += new System.EventHandler(this.FrmProductManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbProductViewer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnManejarInv;
        private System.Windows.Forms.ComboBox cmbValoracionInv;
        private System.Windows.Forms.TextBox txtFinder;
    }
}