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
    public partial class ArticulosGuardar : Form
    {
        ModelDb db = new ModelDb();
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public string TipoInventario { get; set; }
        public decimal CostoUnitario { get; set; }
        public bool Estado { get; set; }
        public string Operacion { get; set; }

        public ArticulosGuardar()
        {
            InitializeComponent();
        }

        private void ArticulosGuardar_Load(object sender, EventArgs e)
        {
            //RefreshComboBox();
            
            if (Operacion.Equals("E"))
            {
                TxtIdArticulo.Text = IdArticulo.ToString();
                TxtDescripcion.Text = Descripcion;
                NudExistencia.Value = Existencia;
                CbxTipoInventario.Text = TipoInventario.ToString();
                TxtCostoUnitario.Text = CostoUnitario.ToString();
                CheckBoxEstado.Checked = Estado;
                button3.Enabled = true;
            }
            if (Operacion.Equals("C"))
            {
                button3.Enabled = false;
            }
        }

        //private void RefreshComboBox()
        //{
        //    try
        //    {
        //        DataRow dr;
        //        SqlCommand cmd = new SqlCommand("select * from TipoInventario", db.con);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);

        //        dr = dt.NewRow();
        //        dr.ItemArray = new object[] { 0, "--Tipos de Inventario--" };
        //        dt.Rows.InsertAt(dr, 0);

        //        CbxTipoInventario.ValueMember = "IdTipoInventario";
        //        CbxTipoInventario.DisplayMember = "Descripcion";
        //        CbxTipoInventario.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR CONSULTANDO LOS TIPOS DE INVENTARIOS." + ex.Message);
        //    }
        //}



        private void BtnGuardarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Operacion.Equals("C"))
                {
                    sql = "insert into Articulo values ('";
                    sql += TxtDescripcion.Text + "','";
                    sql += NudExistencia.Value + "','";
                    sql += TxtCostoUnitario.Text + "','";
                    sql += CheckBoxEstado.Checked + "','";
                    sql += CbxTipoInventario.Items + "')";
                }
                else
                {
                    sql = "update Articulo set ";
                    sql += "Descripcion='" + TxtDescripcion.Text + "',";
                    sql += "Existencia='" + NudExistencia.Value + "',";
                    sql += "IdTipoInventario='" + CbxTipoInventario.Text + "',";
                    sql += "CostoUnitario='" + TxtCostoUnitario.Text + "',";
                    sql += "Estado='" + CheckBoxEstado.Checked + "' ";
                    sql += "where IdArticulo='" + TxtIdArticulo.Text + "'";
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

                string sql = "delete Articulo ";
                sql += "where IdArticulo='" + TxtIdArticulo.Text + "'";

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

        private void button2_Click(object sender, EventArgs e)
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
