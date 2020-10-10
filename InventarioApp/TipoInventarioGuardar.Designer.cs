namespace InventarioApp
{
    partial class TipoInventarioGuardar
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
            this.BtnGuardarTipo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCuentaContable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxEstado = new System.Windows.Forms.CheckBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtIdTipoInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(41, 443);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(154, 59);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(451, 443);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(154, 59);
            this.BtnCerrar.TabIndex = 21;
            this.BtnCerrar.Text = "REGRESAR";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "TIPOS DE INVENTARIOS";
            // 
            // BtnGuardarTipo
            // 
            this.BtnGuardarTipo.Location = new System.Drawing.Point(625, 443);
            this.BtnGuardarTipo.Name = "BtnGuardarTipo";
            this.BtnGuardarTipo.Size = new System.Drawing.Size(155, 59);
            this.BtnGuardarTipo.TabIndex = 20;
            this.BtnGuardarTipo.Text = "GUARDAR";
            this.BtnGuardarTipo.UseVisualStyleBackColor = true;
            this.BtnGuardarTipo.Click += new System.EventHandler(this.BtnGuardarTipo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtCuentaContable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CheckBoxEstado);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtIdTipoInventario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(42, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 321);
            this.panel1.TabIndex = 19;
            // 
            // TxtCuentaContable
            // 
            this.TxtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCuentaContable.Location = new System.Drawing.Point(302, 179);
            this.TxtCuentaContable.Name = "TxtCuentaContable";
            this.TxtCuentaContable.Size = new System.Drawing.Size(405, 29);
            this.TxtCuentaContable.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "CUENTA CONTABLE";
            // 
            // CheckBoxEstado
            // 
            this.CheckBoxEstado.AutoSize = true;
            this.CheckBoxEstado.Location = new System.Drawing.Point(302, 255);
            this.CheckBoxEstado.Name = "CheckBoxEstado";
            this.CheckBoxEstado.Size = new System.Drawing.Size(22, 21);
            this.CheckBoxEstado.TabIndex = 14;
            this.CheckBoxEstado.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Location = new System.Drawing.Point(302, 110);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(405, 29);
            this.TxtDescripcion.TabIndex = 10;
            // 
            // TxtIdTipoInventario
            // 
            this.TxtIdTipoInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdTipoInventario.Enabled = false;
            this.TxtIdTipoInventario.Location = new System.Drawing.Point(302, 39);
            this.TxtIdTipoInventario.Name = "TxtIdTipoInventario";
            this.TxtIdTipoInventario.ReadOnly = true;
            this.TxtIdTipoInventario.Size = new System.Drawing.Size(405, 22);
            this.TxtIdTipoInventario.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRIPCION";
            // 
            // TipoInventarioGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardarTipo);
            this.Controls.Add(this.panel1);
            this.Name = "TipoInventarioGuardar";
            this.Text = "FORMULARIO TIPO INVENTARIO";
            this.Load += new System.EventHandler(this.TipoInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCuentaContable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxEstado;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtIdTipoInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}