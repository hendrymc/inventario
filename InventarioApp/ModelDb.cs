using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace InventarioApp
{
    class ModelDb
    {
        public SqlConnection con = null;
       // DataTable dt = new DataTable();
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

        public void Exportar(string Argumento, string query)
        {
            string sql = query;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            writeFileHeader(Argumento);
            
                foreach (DataRow row in dt.Rows)
                {
                    string linea = "";
                    foreach (DataColumn dc in dt.Columns)
                    {
                        linea += row[dc].ToString() + ",";
                    }
                    writeFileLine(linea);
                }

                Process.Start(@"X:\prueba.csv");
            
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText("X:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText("X:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }
    }
}
