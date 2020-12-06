namespace InventarioApp
{
    partial class GuardarTransaccion
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarArticulo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCostoUnitario = new System.Windows.Forms.TextBox();
            this.TxtIdArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 268);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 32);
            this.button3.TabIndex = 22;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "FORMULARIO DE TRANSACCION";
            // 
            // BtnGuardarArticulo
            // 
            this.BtnGuardarArticulo.Location = new System.Drawing.Point(319, 268);
            this.BtnGuardarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarArticulo.Name = "BtnGuardarArticulo";
            this.BtnGuardarArticulo.Size = new System.Drawing.Size(85, 32);
            this.BtnGuardarArticulo.TabIndex = 20;
            this.BtnGuardarArticulo.Text = "GUARDAR";
            this.BtnGuardarArticulo.UseVisualStyleBackColor = true;
            this.BtnGuardarArticulo.Click += new System.EventHandler(this.BtnGuardarArticulo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxTipoTransaccion);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.TxtCostoUnitario);
            this.panel1.Controls.Add(this.TxtIdArticulo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 228);
            this.panel1.TabIndex = 19;
            // 
            // cbxTipoTransaccion
            // 
            this.cbxTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTransaccion.FormattingEnabled = true;
            this.cbxTipoTransaccion.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbxTipoTransaccion.Location = new System.Drawing.Point(132, 60);
            this.cbxTipoTransaccion.Name = "cbxTipoTransaccion";
            this.cbxTipoTransaccion.Size = new System.Drawing.Size(222, 21);
            this.cbxTipoTransaccion.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(131, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCostoUnitario.Location = new System.Drawing.Point(132, 139);
            this.TxtCostoUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.Size = new System.Drawing.Size(222, 20);
            this.TxtCostoUnitario.TabIndex = 13;
            this.TxtCostoUnitario.TextChanged += new System.EventHandler(this.TxtCostoUnitario_TextChanged);
            this.TxtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoUnitario_KeyPress);
            // 
            // TxtIdArticulo
            // 
            this.TxtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdArticulo.Enabled = false;
            this.TxtIdArticulo.Location = new System.Drawing.Point(132, 19);
            this.TxtIdArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdArticulo.Name = "TxtIdArticulo";
            this.TxtIdArticulo.ReadOnly = true;
            this.TxtIdArticulo.Size = new System.Drawing.Size(221, 13);
            this.TxtIdArticulo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IdArticulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de transacción";
            // 
            // GuardarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardarArticulo);
            this.Controls.Add(this.panel1);
            this.Name = "GuardarTransaccion";
            this.Text = "Guardar Transaccion";
            this.Load += new System.EventHandler(this.GuardarTransaccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarArticulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCostoUnitario;
        private System.Windows.Forms.TextBox TxtIdArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTipoTransaccion;
    }
}