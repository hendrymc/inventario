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
        public Inicio()
        {
            InitializeComponent();
        }

        private void existenciasXAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
