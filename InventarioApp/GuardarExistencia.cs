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
    public partial class GuardarExistencia : Form
    {
        ModelDb db = new ModelDb();
        public string IdArticulo { get; set; }
        public string IdAlmacen { get; set; }
        public int cantidad { get; set; }
        public string Operacion { get; set; }


        public GuardarExistencia()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarExistencia_Load(object sender, EventArgs e)
        {
            if (Operacion.Equals("E"))
            {
                cbxIdarticulo.Text = IdArticulo.ToString();
                cbdAlmacen.Text = IdAlmacen.ToString();
                txtCantidad.Text = cantidad.ToString();
                button3.Enabled = true;
            }

            if (Operacion.Equals("C")) {
                button3.Enabled = false;
            }
        }

        private void BtnGuardarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Operacion.Equals("C"))
                {
                    sql = "insert into ExistenciaAlmacen values ('";
                    sql += cbdAlmacen.Text + "','";
                    sql += cbxIdarticulo.Text + "','";
                    sql += txtCantidad.Text + "')";
                }
                else
                {
                    sql = "update ExistenciaAlmacen set ";
                    sql += "IdAlmacen='" + cbdAlmacen.Text + "',";
                    sql += "IdArticulo='" + cbxIdarticulo.Text + "',";
                    sql += "Cantidad='" + txtCantidad.Text + "' ";
                    sql += "where IdArticulo='" + cbxIdarticulo.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("REGISTRO GUARDADO CON EXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ACTUALIZANDO EL ARTICULO." + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "delete ExistenciaAlmacen ";
                sql += "where IdArticulo='" + cbxIdarticulo.Text + "'";

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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
    }
    

