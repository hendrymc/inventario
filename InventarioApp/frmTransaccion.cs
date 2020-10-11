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
    public partial class frmTransaccion : Form
    {
        ModelDb db = new ModelDb();

        public frmTransaccion()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransaccion_Load(object sender, EventArgs e)
        {
            db.GetTransaccion(DgvTransaccion);
        }

        private void frmTransaccion_Activated(object sender, EventArgs e)
        {
            db.GetTransaccion(DgvTransaccion);
        }

        private void BtnTransaccion_Click(object sender, EventArgs e)
        {
            GuardarTransaccion tran = new GuardarTransaccion();
            tran.Operacion = "C";
            tran.ShowDialog();
        }

        private void DgvTransaccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DgvTransaccion.SelectedRows[0];
                GuardarTransaccion FormItem = new GuardarTransaccion();
                FormItem.IdTransaccion = int.Parse(row.Cells[0].Value.ToString());
                FormItem.TipoTransaccion = row.Cells[1].Value.ToString();
                FormItem.Fecha = DateTime.Parse(row.Cells[2].Value.ToString());
                FormItem.cantidad = int.Parse(row.Cells[3].Value.ToString());
                FormItem.IdArticulo = row.Cells[4].Value.ToString();
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
