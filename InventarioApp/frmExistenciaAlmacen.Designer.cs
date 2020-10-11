namespace InventarioApp
{
    partial class frmExistenciaAlmacen
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
            this.DgvExistencia = new System.Windows.Forms.DataGridView();
            this.BtnNuevaExistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(485, 319);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(74, 32);
            this.BtnRegresar.TabIndex = 12;
            this.BtnRegresar.Text = "CERRAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvExistencia
            // 
            this.DgvExistencia.AllowUserToAddRows = false;
            this.DgvExistencia.AllowUserToDeleteRows = false;
            this.DgvExistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExistencia.Location = new System.Drawing.Point(11, 33);
            this.DgvExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.DgvExistencia.Name = "DgvExistencia";
            this.DgvExistencia.ReadOnly = true;
            this.DgvExistencia.RowHeadersWidth = 72;
            this.DgvExistencia.RowTemplate.Height = 31;
            this.DgvExistencia.Size = new System.Drawing.Size(677, 274);
            this.DgvExistencia.TabIndex = 11;
            this.DgvExistencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExistencia_CellDoubleClick);
            // 
            // BtnNuevaExistencia
            // 
            this.BtnNuevaExistencia.Location = new System.Drawing.Point(569, 319);
            this.BtnNuevaExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevaExistencia.Name = "BtnNuevaExistencia";
            this.BtnNuevaExistencia.Size = new System.Drawing.Size(119, 32);
            this.BtnNuevaExistencia.TabIndex = 10;
            this.BtnNuevaExistencia.Text = "NUEVA EXISTENCIA";
            this.BtnNuevaExistencia.UseVisualStyleBackColor = true;
            this.BtnNuevaExistencia.Click += new System.EventHandler(this.BtnNuevaExistencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "PANEL DE EXISTENCIA ALMACÉN";
            // 
            // frmExistenciaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 357);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvExistencia);
            this.Controls.Add(this.BtnNuevaExistencia);
            this.Controls.Add(this.label1);
            this.Name = "frmExistenciaAlmacen";
            this.Text = "Existencia Almacen";
            this.Activated += new System.EventHandler(this.frmExistenciaAlmacen_Activated);
            this.Load += new System.EventHandler(this.frmExistenciaAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvExistencia;
        private System.Windows.Forms.Button BtnNuevaExistencia;
        private System.Windows.Forms.Label label1;
    }
}