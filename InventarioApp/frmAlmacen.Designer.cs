﻿namespace InventarioApp
{
    partial class frmAlmacen
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DgvAlmacen = new System.Windows.Forms.DataGridView();
            this.BtnCrearArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(486, 380);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(74, 32);
            this.BtnRegresar.TabIndex = 8;
            this.BtnRegresar.Text = "CERRAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvAlmacen
            // 
            this.DgvAlmacen.AllowUserToAddRows = false;
            this.DgvAlmacen.AllowUserToDeleteRows = false;
            this.DgvAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlmacen.Location = new System.Drawing.Point(12, 94);
            this.DgvAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.DgvAlmacen.Name = "DgvAlmacen";
            this.DgvAlmacen.ReadOnly = true;
            this.DgvAlmacen.RowHeadersWidth = 72;
            this.DgvAlmacen.RowTemplate.Height = 31;
            this.DgvAlmacen.Size = new System.Drawing.Size(677, 274);
            this.DgvAlmacen.TabIndex = 7;
            this.DgvAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlmacen_CellContentClick);
            this.DgvAlmacen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlmacen_CellDoubleClick);
            // 
            // BtnCrearArticulo
            // 
            this.BtnCrearArticulo.Location = new System.Drawing.Point(570, 380);
            this.BtnCrearArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCrearArticulo.Name = "BtnCrearArticulo";
            this.BtnCrearArticulo.Size = new System.Drawing.Size(119, 32);
            this.BtnCrearArticulo.TabIndex = 6;
            this.BtnCrearArticulo.Text = "CREAR ALMACEN";
            this.BtnCrearArticulo.UseVisualStyleBackColor = true;
            this.BtnCrearArticulo.Click += new System.EventHandler(this.BtnCrearArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PANEL DE ALMACÉN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 60);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(359, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 51);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto a buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(124, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(203, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvAlmacen);
            this.Controls.Add(this.BtnCrearArticulo);
            this.Controls.Add(this.label1);
            this.Name = "frmAlmacen";
            this.Text = "Almacen";
            this.Activated += new System.EventHandler(this.frmAlmacen_Activated);
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvAlmacen;
        private System.Windows.Forms.Button BtnCrearArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button button1;
    }
}