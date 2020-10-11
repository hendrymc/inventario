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
    public partial class frmExistenciaAlmacen : Form
    {
        ModelDb db = new ModelDb();

        public frmExistenciaAlmacen()
        {
            InitializeComponent();
        }

        private void frmExistenciaAlmacen_Load(object sender, EventArgs e)
        {
            db.GetExistenciasAlmacen(DgvExistencia);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevaExistencia_Click(object sender, EventArgs e)
        {
            GuardarExistencia exi = new GuardarExistencia();
            exi.Operacion = "C";
            exi.ShowDialog();
            
        }

        private void frmExistenciaAlmacen_Activated(object sender, EventArgs e)
        {
            db.GetExistenciasAlmacen(DgvExistencia);
        }

        private void DgvExistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DgvExistencia.SelectedRows[0];
                GuardarExistencia FormItem = new GuardarExistencia();
                FormItem.IdArticulo = row.Cells[0].Value.ToString();
                FormItem.IdAlmacen = row.Cells[1].Value.ToString();
                FormItem.cantidad = int.Parse(row.Cells[2].Value.ToString());
                FormItem.Operacion = "E";
                FormItem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ABRIENDO EL ARTICULO." + ex.Message);
            }
        }
    }
}
