namespace InventarioApp
{
    partial class TipoInventarioListar
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
            this.DgvInventarios = new System.Windows.Forms.DataGridView();
            this.BtnCrearInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(822, 602);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(145, 59);
            this.BtnRegresar.TabIndex = 8;
            this.BtnRegresar.Text = "CERRAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvInventarios
            // 
            this.DgvInventarios.AllowUserToAddRows = false;
            this.DgvInventarios.AllowUserToDeleteRows = false;
            this.DgvInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventarios.Location = new System.Drawing.Point(22, 74);
            this.DgvInventarios.Name = "DgvInventarios";
            this.DgvInventarios.ReadOnly = true;
            this.DgvInventarios.RowHeadersWidth = 72;
            this.DgvInventarios.RowTemplate.Height = 31;
            this.DgvInventarios.Size = new System.Drawing.Size(1241, 506);
            this.DgvInventarios.TabIndex = 7;
            this.DgvInventarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInventarios_CellDoubleClick);
            // 
            // BtnCrearInventario
            // 
            this.BtnCrearInventario.Location = new System.Drawing.Point(984, 602);
            this.BtnCrearInventario.Name = "BtnCrearInventario";
            this.BtnCrearInventario.Size = new System.Drawing.Size(279, 59);
            this.BtnCrearInventario.TabIndex = 6;
            this.BtnCrearInventario.Text = "CREAR INVENTARIO";
            this.BtnCrearInventario.UseVisualStyleBackColor = true;
            this.BtnCrearInventario.Click += new System.EventHandler(this.BtnCrearInventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "PANEL TIPOS DE INVENTARIOS";
            // 
            // TipoInventarioListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 688);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvInventarios);
            this.Controls.Add(this.BtnCrearInventario);
            this.Controls.Add(this.label1);
            this.Name = "TipoInventarioListar";
            this.Text = "TIPOS DE INVENTARIOS";
            this.Activated += new System.EventHandler(this.TipoInventarioListar_Activated);
            this.Load += new System.EventHandler(this.TipoInventarioListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvInventarios;
        private System.Windows.Forms.Button BtnCrearInventario;
        private System.Windows.Forms.Label label1;
    }
}