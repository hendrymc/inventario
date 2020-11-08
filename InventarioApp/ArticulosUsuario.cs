using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class ArticulosUsuario : Form
    {
        ModelDb db = new ModelDb();

        public ArticulosUsuario()
        {
            InitializeComponent();
        }

        private void ArticulosUsuario_Load(object sender, EventArgs e)
        {
            db.GetArticulos(DgvArticulos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sSQL = "select * from Articulo ";
            sSQL += "where Descripcion";
            sSQL += " like '%" + txtBusqueda.Text + "%'";
            // sSQL += " order by " + cbxCriterios.SelectedItem;
            db.ejecutarConsultaBD(sSQL, DgvArticulos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sSQL = "select * from Articulo";
            db.ejecutarConsultaBD(sSQL, DgvArticulos);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
