using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProyectoLista
{
    public partial class Productos_de_venta : Form
    {
        private List<clases.Productos> lista = new List<clases.Productos>();
        public Productos_de_venta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clases.Productos producto = new clases.Productos();
            producto.Codigo = this.txtCodigo.Text;
            producto.NombreProducto = this.txtNombredelProducto.Text;
            producto.PrecioVenta = Double.Parse(this.txtPreciodeVenta.Text);
            producto.Fechacompra = DateTime.Parse(this.txtFechadeCompra.Text);
            producto.Unidad = int.Parse(this.txtUnidades.Text);

            lista.Add(producto);

            //mostrar los productos en el listview
            ListViewItem item = new ListViewItem(producto.Codigo);
            listViewProductos.Items.Add(item);
            item.SubItems.Add(producto.NombreProducto);
            item.SubItems.Add(producto.PrecioVenta.ToString());
            item.SubItems.Add(producto.Fechacompra.ToString());
            item.SubItems.Add(producto.Unidad.ToString());

            this.txtCodigo.Clear();
            this.txtNombredelProducto.Clear();
            this.txtPreciodeVenta.Clear();
            this.txtFechadeCompra.Clear();
            this.txtUnidades.Clear();

        }
    }
}
