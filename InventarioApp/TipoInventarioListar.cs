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
    public partial class TipoInventarioListar : Form
    {
        ModelDb db = new ModelDb();
        public TipoInventarioListar()
        {
            InitializeComponent();
        }

        private void TipoInventarioListar_Load(object sender, EventArgs e)
        {
            db.GetInventario(DgvInventarios);
        }

        private void DgvInventarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DgvInventarios.SelectedRows[0];
                TipoInventarioGuardar FormItem = new TipoInventarioGuardar();
                FormItem.IdTipoInventario = int.Parse(row.Cells[0].Value.ToString());
                FormItem.Descripcion = row.Cells[1].Value.ToString();
                FormItem.CuentaContable = row.Cells[2].Value.ToString();
                FormItem.Estado = (bool)row.Cells[3].Value;
                FormItem.Operacion = "E";
                FormItem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ABRIENDO EL TIPO DE INVENTARIO." + ex.Message);
            }
        }

        private void BtnCrearInventario_Click(object sender, EventArgs e)
        {
            TipoInventarioGuardar FormItem = new TipoInventarioGuardar();
            FormItem.Operacion = "C";
            FormItem.ShowDialog();
        }

        private void TipoInventarioListar_Activated(object sender, EventArgs e)
        {
            db.GetInventario(DgvInventarios);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
