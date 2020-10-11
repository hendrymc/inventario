namespace InventarioApp
{
    partial class frmTransaccion
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
            this.DgvTransaccion = new System.Windows.Forms.DataGridView();
            this.BtnTransaccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(457, 325);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(74, 32);
            this.BtnRegresar.TabIndex = 8;
            this.BtnRegresar.Text = "CERRAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvTransaccion
            // 
            this.DgvTransaccion.AllowUserToAddRows = false;
            this.DgvTransaccion.AllowUserToDeleteRows = false;
            this.DgvTransaccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTransaccion.Location = new System.Drawing.Point(11, 39);
            this.DgvTransaccion.Margin = new System.Windows.Forms.Padding(2);
            this.DgvTransaccion.Name = "DgvTransaccion";
            this.DgvTransaccion.ReadOnly = true;
            this.DgvTransaccion.RowHeadersWidth = 72;
            this.DgvTransaccion.RowTemplate.Height = 31;
            this.DgvTransaccion.Size = new System.Drawing.Size(677, 274);
            this.DgvTransaccion.TabIndex = 7;
            this.DgvTransaccion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransaccion_CellContentDoubleClick);
            // 
            // BtnTransaccion
            // 
            this.BtnTransaccion.Location = new System.Drawing.Point(549, 325);
            this.BtnTransaccion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTransaccion.Name = "BtnTransaccion";
            this.BtnTransaccion.Size = new System.Drawing.Size(139, 32);
            this.BtnTransaccion.TabIndex = 6;
            this.BtnTransaccion.Text = "NUEVA TRANSACCION";
            this.BtnTransaccion.UseVisualStyleBackColor = true;
            this.BtnTransaccion.Click += new System.EventHandler(this.BtnTransaccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PANEL DE TRANSACCIONES";
            // 
            // frmTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 362);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvTransaccion);
            this.Controls.Add(this.BtnTransaccion);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaccion";
            this.Text = "Transacción";
            this.Activated += new System.EventHandler(this.frmTransaccion_Activated);
            this.Load += new System.EventHandler(this.frmTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvTransaccion;
        private System.Windows.Forms.Button BtnTransaccion;
        private System.Windows.Forms.Label label1;
    }
}