using System;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class ArticulosListar : Form
    {
        ModelDb db = new ModelDb();
        

        public ArticulosListar()
        {
            InitializeComponent();
        }

        private void ArticulosListar_Load(object sender, EventArgs e)
        {
            db.GetArticulos(DgvArticulos);
        }

        private void BtnCrearArticulo_Click(object sender, EventArgs e)
        {
            ArticulosGuardar FormItem = new ArticulosGuardar();
            FormItem.Operacion = "C";
            FormItem.ShowDialog();
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DgvArticulos.SelectedRows[0];
                ArticulosGuardar FormItem = new ArticulosGuardar();
                FormItem.IdArticulo = int.Parse(row.Cells[0].Value.ToString());
                FormItem.Descripcion = row.Cells[1].Value.ToString();
                FormItem.Existencia = int.Parse(row.Cells[2].Value.ToString());
                FormItem.CostoUnitario = decimal.Parse(row.Cells[3].Value.ToString());
                FormItem.Estado = (bool)row.Cells[4].Value;
                FormItem.TipoInventario = row.Cells[5].Value.ToString();
                FormItem.Operacion = "E";
                FormItem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ABRIENDO EL ARTICULO." + ex.Message);
            }
        }

        private void ArticulosListar_Activated(object sender, EventArgs e)
        {
            db.GetArticulos(DgvArticulos);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
