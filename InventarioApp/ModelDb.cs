using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventarioApp
{
    class ModelDb
    {
        public SqlConnection con = null;

        public ModelDb()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=inventariodb;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONECTANDO A LA BASE DE DATOS. " + ex.Message);
            }
        }

        public void GetArticulos(DataGridView ItemsList)
        {
            try
            {
                string sql = "select * from Articulo";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemsList.DataSource = dt;
                ItemsList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONSULTANDO LA BASE DE DATOS. " + ex.Message);
            }
        }

        public void GetInventario(DataGridView ItemsList)
        {
            try
            {
                string sql = "select * from TipoInventario";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemsList.DataSource = dt;
                ItemsList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONSULTANDO LA BASE DE DATOS. " + ex.Message);
            }
        }
    }
}
