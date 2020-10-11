namespace InventarioApp
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(485, 324);
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
            this.DgvAlmacen.Location = new System.Drawing.Point(11, 38);
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
            this.BtnCrearArticulo.Location = new System.Drawing.Point(569, 324);
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
            // frmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 364);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvAlmacen);
            this.Controls.Add(this.BtnCrearArticulo);
            this.Controls.Add(this.label1);
            this.Name = "frmAlmacen";
            this.Text = "Almacen";
            this.Activated += new System.EventHandler(this.frmAlmacen_Activated);
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvAlmacen;
        private System.Windows.Forms.Button BtnCrearArticulo;
        private System.Windows.Forms.Label label1;
    }
}