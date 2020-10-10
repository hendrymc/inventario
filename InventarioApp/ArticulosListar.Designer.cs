namespace InventarioApp
{
    partial class ArticulosListar
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnCrearArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PANEL DE ARTICULOS";
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Location = new System.Drawing.Point(26, 74);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.RowHeadersWidth = 72;
            this.DgvArticulos.RowTemplate.Height = 31;
            this.DgvArticulos.Size = new System.Drawing.Size(1241, 506);
            this.DgvArticulos.TabIndex = 3;
            this.DgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulos_CellDoubleClick);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(895, 602);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(135, 59);
            this.BtnRegresar.TabIndex = 4;
            this.BtnRegresar.Text = "CERRAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnCrearArticulo
            // 
            this.BtnCrearArticulo.Location = new System.Drawing.Point(1049, 602);
            this.BtnCrearArticulo.Name = "BtnCrearArticulo";
            this.BtnCrearArticulo.Size = new System.Drawing.Size(218, 59);
            this.BtnCrearArticulo.TabIndex = 2;
            this.BtnCrearArticulo.Text = "CREAR ARTICULO";
            this.BtnCrearArticulo.UseVisualStyleBackColor = true;
            this.BtnCrearArticulo.Click += new System.EventHandler(this.BtnCrearArticulo_Click);
            // 
            // ArticulosListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 688);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvArticulos);
            this.Controls.Add(this.BtnCrearArticulo);
            this.Controls.Add(this.label1);
            this.Name = "ArticulosListar";
            this.Text = "ARTICULOS";
            this.Activated += new System.EventHandler(this.ArticulosListar_Activated);
            this.Load += new System.EventHandler(this.ArticulosListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnCrearArticulo;
    }
}