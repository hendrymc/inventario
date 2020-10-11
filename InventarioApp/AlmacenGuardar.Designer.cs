namespace InventarioApp
{
    partial class AlmacenGuardar
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarAlmacen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxEstado = new System.Windows.Forms.CheckBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtAlmacen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(13, 209);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(84, 32);
            this.BtnEliminar.TabIndex = 27;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(237, 209);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(84, 32);
            this.BtnCerrar.TabIndex = 26;
            this.BtnCerrar.Text = "REGRESAR";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "TIPOS DE ALMACEN";
            // 
            // BtnGuardarAlmacen
            // 
            this.BtnGuardarAlmacen.Location = new System.Drawing.Point(332, 209);
            this.BtnGuardarAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarAlmacen.Name = "BtnGuardarAlmacen";
            this.BtnGuardarAlmacen.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardarAlmacen.TabIndex = 25;
            this.BtnGuardarAlmacen.Text = "GUARDAR";
            this.BtnGuardarAlmacen.UseVisualStyleBackColor = true;
            this.BtnGuardarAlmacen.Click += new System.EventHandler(this.BtnGuardarAlmacen_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CheckBoxEstado);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtAlmacen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 154);
            this.panel1.TabIndex = 24;
            // 
            // CheckBoxEstado
            // 
            this.CheckBoxEstado.AutoSize = true;
            this.CheckBoxEstado.Location = new System.Drawing.Point(165, 114);
            this.CheckBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxEstado.Name = "CheckBoxEstado";
            this.CheckBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxEstado.TabIndex = 14;
            this.CheckBoxEstado.UseVisualStyleBackColor = true;
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
            // TxtAlmacen
            // 
            this.TxtAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAlmacen.Enabled = false;
            this.TxtAlmacen.Location = new System.Drawing.Point(165, 21);
            this.TxtAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAlmacen.Name = "TxtAlmacen";
            this.TxtAlmacen.ReadOnly = true;
            this.TxtAlmacen.Size = new System.Drawing.Size(221, 13);
            this.TxtAlmacen.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ESTADO";
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
            // AlmacenGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardarAlmacen);
            this.Controls.Add(this.panel1);
            this.Name = "AlmacenGuardar";
            this.Text = "AlmacenGuardar";
            this.Load += new System.EventHandler(this.AlmacenGuardar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarAlmacen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckBoxEstado;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtAlmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}