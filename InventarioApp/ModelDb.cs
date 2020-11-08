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
                con = new SqlConnection("Data Source=DESKTOP-11AN0PI\\MSSQLSERVER2;Initial Catalog=inventario_db;Integrated Security=True");
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
        public void GetAlmacen(DataGridView ItemList)
        {
            try
            {
                string sql = "select * from Almacen";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemList.DataSource = dt;
                ItemList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONSULTANDO LA BASE DE DATOS. " + ex.Message);

            }
        
        }

        internal void ejecutarConsultaBD(string sSQL, DataGridView ItemList)
        {
            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, con);
            DataTable oTable = new DataTable();
            oDa.Fill(oTable);
            ItemList.DataSource = oTable;
            ItemList.Refresh();
        }

        public void GetExistenciasAlmacen(DataGridView ItemList)
        {
            try
            {
                string sql = "select * from ExistenciaAlmacen";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemList.DataSource = dt;
                ItemList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONSULTANDO LA BASE DE DATOS. " + ex.Message);

            }

        }
        public void GetTransaccion(DataGridView ItemList)
        {
            try
            {
                string sql = "select * from Transaccion";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ItemList.DataSource = dt;
                ItemList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONSULTANDO LA BASE DE DATOS. " + ex.Message);

            }
        }

        public void Rol() {

        }
    }
}
