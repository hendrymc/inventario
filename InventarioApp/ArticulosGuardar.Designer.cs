namespace InventarioApp
{
    partial class ArticulosGuardar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.CbxTipoInventario = new System.Windows.Forms.ComboBox();
            this.NudExistencia = new System.Windows.Forms.NumericUpDown();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtIdArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnGuardarArticulo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FORMULARIO DE ARTICULO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EXISTENCIA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.TxtCostoUnitario);
            this.panel1.Controls.Add(this.CbxTipoInventario);
            this.panel1.Controls.Add(this.NudExistencia);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtIdArticulo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 260);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.ItemHeight = 13;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(163, 217);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(223, 21);
            this.cbxEstado.TabIndex = 14;
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCostoUnitario.Location = new System.Drawing.Point(165, 178);
            this.TxtCostoUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(222, 20);
            this.TxtCostoUnitario.TabIndex = 13;
            this.TxtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoUnitario_KeyPress);
            // 
            // CbxTipoInventario
            // 
            this.CbxTipoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoInventario.FormattingEnabled = true;
            this.CbxTipoInventario.ItemHeight = 13;
            this.CbxTipoInventario.Location = new System.Drawing.Point(165, 138);
            this.CbxTipoInventario.Margin = new System.Windows.Forms.Padding(2);
            this.CbxTipoInventario.Name = "CbxTipoInventario";
            this.CbxTipoInventario.Size = new System.Drawing.Size(223, 21);
            this.CbxTipoInventario.TabIndex = 12;
            // 
            // NudExistencia
            // 
            this.NudExistencia.Location = new System.Drawing.Point(165, 100);
            this.NudExistencia.Margin = new System.Windows.Forms.Padding(2);
            this.NudExistencia.Name = "NudExistencia";
            this.NudExistencia.Size = new System.Drawing.Size(221, 20);
            this.NudExistencia.TabIndex = 11;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Location = new System.Drawing.Point(165, 60);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(222, 20);
            this.TxtDescripcion.TabIndex = 10;
            // 
            // TxtIdArticulo
            // 
            this.TxtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdArticulo.Enabled = false;
            this.TxtIdArticulo.Location = new System.Drawing.Point(165, 21);
            this.TxtIdArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdArticulo.Name = "TxtIdArticulo";
            this.TxtIdArticulo.ReadOnly = true;
            this.TxtIdArticulo.Size = new System.Drawing.Size(221, 13);
            this.TxtIdArticulo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "COSTO UNITARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TIPO DE INVENTARIO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnGuardarArticulo
            // 
            this.BtnGuardarArticulo.Location = new System.Drawing.Point(336, 330);
            this.BtnGuardarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarArticulo.Name = "BtnGuardarArticulo";
            this.BtnGuardarArticulo.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardarArticulo.TabIndex = 15;
            this.BtnGuardarArticulo.Text = "GUARDAR";
            this.BtnGuardarArticulo.UseVisualStyleBackColor = true;
            this.BtnGuardarArticulo.Click += new System.EventHandler(this.BtnGuardarArticulo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 330);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ArticulosGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 379);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardarArticulo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArticulosGuardar";
            this.Text = "FORMULARIO DE ARTICULO";
            this.Load += new System.EventHandler(this.ArticulosGuardar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtIdArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCostoUnitario;
        private System.Windows.Forms.ComboBox CbxTipoInventario;
        private System.Windows.Forms.NumericUpDown NudExistencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnGuardarArticulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}