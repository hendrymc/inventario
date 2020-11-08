using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class Login : Form
    {
        ModelDb db = new ModelDb();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-11AN0PI\\MSSQLSERVER2;Initial Catalog=inventario_db;Integrated Security=True");
            con.Open();

           string claveMD5 = getMD5Hash(TextBoxClave.Text);
            string sql = "select * from Usuario where Estado = 'A' and Clave = '" + claveMD5 + "' and IdUsuario = @usuario;";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
            cmd.Parameters["@usuario"].Value = TextBoxUsuario.Text;
            string sExist = "";
            
            try
            {
                sExist = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            if (!String.IsNullOrEmpty(sExist))
            {
                //Inicio frmInicio = new Inicio();
                //frmInicio.Show();
                Rol();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }

        public string getMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public void Rol() {
            string claveMD5 = getMD5Hash(TextBoxClave.Text);
            string sql = "select rol from Usuario where Estado = 'A' and Clave = '" + claveMD5 + "' and IdUsuario = '"+ TextBoxUsuario.Text+"';";
            SqlDataAdapter da = new SqlDataAdapter(sql, db.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["rol"].ToString() == "Administrador") {
                    Inicio frmInicio = new Inicio();
                    frmInicio.Show();
                }
                else if (dt.Rows[0]["rol"].ToString() == "Usuario") {
                    InicioUsuario frminiciousuario = new InicioUsuario();
                    frminiciousuario.Show();
                }
            }
                //return variable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
