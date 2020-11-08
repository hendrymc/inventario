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
    public partial class Inicio : Form
    {
        Login login = new Login();

        public Inicio()
        {
            InitializeComponent();
        }


        private void existenciasXAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExistenciaAlmacen exi = new frmExistenciaAlmacen();
            exi.ShowDialog();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticulosListar al = new ArticulosListar();
            al.ShowDialog();
        }

        private void tiposDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoInventarioListar til = new TipoInventarioListar();
            til.ShowDialog();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlmacen alm = new frmAlmacen();
            alm.ShowDialog();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaccion tran = new frmTransaccion();
            tran.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }
    }
}
                
