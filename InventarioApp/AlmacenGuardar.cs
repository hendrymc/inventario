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
    public partial class AlmacenGuardar : Form
    {
        ModelDb db = new ModelDb();

        public int IdAlmacen { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Operacion { get; set;}

        public AlmacenGuardar()
        {
            InitializeComponent();
        }

        private void AlmacenGuardar_Load(object sender, EventArgs e)
        {
             if (Operacion.Equals("E"))
             {
                 TxtAlmacen.Text = IdAlmacen.ToString();
                 TxtDescripcion.Text = Descripcion;
                 cbxEstado.Text = Estado;
                BtnEliminar.Enabled = true;
            }
            if (Operacion.Equals("C")) {
                BtnEliminar.Enabled = false;
            }
            
        }

        private void BtnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Operacion.Equals("C"))
                {
                    sql = "insert into Almacen values ('";
                    sql += TxtDescripcion.Text + "','";
                    sql += cbxEstado.Text + "')";
                }
                else
                {
                    sql = "update Almacen set ";
                    sql += "Descripcion='" + TxtDescripcion.Text + "',";
                    sql += "Estado='" + cbxEstado.Text + "' ";
                    sql += "where IdAlmacen='" + TxtAlmacen.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, db.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO GUARDADO CON EXITO");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ACTUALIZANDO EL ALMACEN." + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Almacen ";
                sql += "where IdAlmacen='" + TxtAlmacen.Text + "'";

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

       
    }
}
