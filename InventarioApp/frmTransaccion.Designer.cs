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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransaccion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(453, 388);
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
            this.DgvTransaccion.Location = new System.Drawing.Point(7, 102);
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
            this.BtnTransaccion.Location = new System.Drawing.Point(545, 388);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Location = new System.Drawing.Point(7, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 67);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Formato para buscar por fecha: AAAA-MM-DD";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(358, 9);
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
            this.button1.Location = new System.Drawing.Point(439, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvTransaccion);
            this.Controls.Add(this.BtnTransaccion);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaccion";
            this.Text = "Transacción";
            this.Activated += new System.EventHandler(this.frmTransaccion_Activated);
            this.Load += new System.EventHandler(this.frmTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransaccion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvTransaccion;
        private System.Windows.Forms.Button BtnTransaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}