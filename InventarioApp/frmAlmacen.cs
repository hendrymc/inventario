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
    public partial class frmAlmacen : Form
    {
        ModelDb db = new ModelDb();

        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            db.GetAlmacen(DgvAlmacen);
        }

        private void BtnCrearArticulo_Click(object sender, EventArgs e)
        {
            {
                AlmacenGuardar FormItem = new AlmacenGuardar();
                FormItem.Operacion = "C";
                FormItem.ShowDialog();            
            }
        }
        private void frmAlmacen_Activated(object sender, EventArgs e)
        {
            db.GetAlmacen(DgvAlmacen);
        }

        private void DgvAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DgvAlmacen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DgvAlmacen.SelectedRows[0];
                AlmacenGuardar FormItem = new AlmacenGuardar();
                FormItem.IdAlmacen = int.Parse(row.Cells[0].Value.ToString());
                FormItem.Descripcion = row.Cells[1].Value.ToString();
                FormItem.Estado = (bool)row.Cells[2].Value;
                FormItem.Operacion = "E";
                FormItem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ABRIENDO EL ALMACEN." + ex.Message);
            }
        }
    }
}
