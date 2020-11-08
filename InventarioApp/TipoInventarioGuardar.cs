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
    public partial class TipoInventarioGuardar : Form
    {
        ModelDb db = new ModelDb();
        public int IdTipoInventario { get; set; }
        public string Descripcion { get; set; }
        public string CuentaContable { get; set; }
        public string Estado { get; set; }
        public string Operacion { get; set; }
        
        public TipoInventarioGuardar()
        {
            InitializeComponent();
        }

        private void TipoInventario_Load(object sender, EventArgs e)
        {
            if(Operacion.Equals("E"))
            {
                TxtIdTipoInventario.Text = IdTipoInventario.ToString();
                TxtDescripcion.Text = Descripcion;
                TxtCuentaContable.Text = CuentaContable;
                CbxEstado.Text = Estado;
                BtnEliminar.Enabled = true;
            }
            if (Operacion.Equals("C"))
            {
                BtnEliminar.Enabled = false;
            }
        }

        private void BtnGuardarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Operacion.Equals("C"))
                {
                    sql = "insert into TipoInventario values ('";
                    sql += TxtDescripcion.Text + "','";
                    sql += TxtCuentaContable.Text + "','";
                    sql += CbxEstado.Text + "')";
                }
                else
                {
                    sql = "update TipoInventario set ";
                    sql += "Descripcion='" + TxtDescripcion.Text + "',";
                    sql += "CuentaContable='" + TxtCuentaContable.Text + "',";
                    sql += "Estado='" + CbxEstado.Text + "' ";
                    sql += "where IdTipoInventario='" + TxtIdTipoInventario.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO GUARDADO CON EXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ACTUALIZANDO EL INVENTARIO." + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete TipoInventario ";
                sql += "where IdTipoInventario='" + TxtIdTipoInventario.Text + "'";

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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
