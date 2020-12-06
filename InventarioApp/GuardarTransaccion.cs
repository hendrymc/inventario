using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class GuardarTransaccion : Form
    {
        ModelDb db = new ModelDb();
        public int IdTransaccion { get; set; }
        public string TipoTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public int cantidad { get; set; }
        public string IdArticulo { get; set; }
        public string Operacion { get; set; }
        public int Existencia { get; set; }
        public GuardarTransaccion()
        {
            InitializeComponent();
        }

        private void NudExistencia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GuardarTransaccion_Load(object sender, EventArgs e)
        {
            cbxTipoTransaccion.SelectedIndex = 0;
            if (Operacion.Equals("E"))
            {
                TxtIdArticulo.Text = IdTransaccion.ToString();
                cbxTipoTransaccion.Text = TipoTransaccion;
                dateTimePicker1.Value = Fecha;
                textBox1.Text = IdArticulo;
                TxtCostoUnitario.Text = cantidad.ToString();
                button3.Enabled = true;
            }
            if (Operacion.Equals("C"))
            {
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";

                if (Operacion.Equals("C"))
                {
                    sql = "insert into Transaccion values ('";
                    sql += cbxTipoTransaccion.Text + "','";
                    sql += dateTimePicker1.Value + "','";
                    sql += TxtCostoUnitario.Text + "','";
                    sql += textBox1.Text + "')";

                    if (cbxTipoTransaccion.Text == "Entrada")
                    {
                        sql += "update Articulo ";
                        sql += "set Existencia = Existencia + '" + TxtCostoUnitario.Text + "' ";
                        sql += "where IdArticulo='" + textBox1.Text + "'";
                    }
                    else if (cbxTipoTransaccion.Text == "Salida")
                    {
                        sql += "update Articulo ";
                        sql += "set Existencia = Existencia - '" + TxtCostoUnitario.Text + "' ";
                        sql += "where IdArticulo='" + textBox1.Text + "'";
                    }
                }
                else
                {
                    sql = "update Transaccion set ";
                    sql += "TipoTransaccion='" + cbxTipoTransaccion.Text + "',";
                    sql += "Fecha='" + dateTimePicker1.Value + "',";
                    sql += "Cantidad='" + TxtCostoUnitario.Text + "',";
                    sql += "IdArticulo='" + textBox1.Text + "' ";
                    sql += "where IdTransaccion='" + TxtIdArticulo.Text + "'";

                    if (cbxTipoTransaccion.Text == "Entrada")
                    {
                        sql += "update Articulo ";
                        sql += "set Existencia = Existencia + '" + TxtCostoUnitario.Text + "' ";
                        sql += "where IdArticulo='" + textBox1.Text + "'";
                    }
                    else if (cbxTipoTransaccion.Text == "Salida")
                    {
                        
                        sql += "update Articulo ";
                        sql += "set Existencia = Existencia - '" + TxtCostoUnitario.Text + "' ";
                        sql += "where IdArticulo='" + textBox1.Text + "'";
                    }
                }
                    SqlCommand cmd = new SqlCommand(sql, db.con);
                    cmd.ExecuteNonQuery();
                
                MessageBox.Show("REGISTRO GUARDADO CON EXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ACTUALIZANDO LA TRANSACCION." + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Transaccion ";
                sql += "where IdTransaccion='" + TxtIdArticulo.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO CON EXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ELIMINANDO REGISTRO." + ex.Message);
            }
        }

        private void TxtCostoUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
