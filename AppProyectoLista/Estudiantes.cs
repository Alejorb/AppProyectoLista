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
    public partial class Estudiantes : Form
    {
        private List<clases.Estudiantes> lista =new List<clases.Estudiantes>();
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clases.Estudiantes estudiantes = new clases.Estudiantes();
            estudiantes.NombreCompleto = this.txtNombreCompleto.Text;
            estudiantes.Genero = this.cmbGenero.Text;
            estudiantes.EstadoCivil = this.cmbEstadoCivil.Text;
            estudiantes.edad = Convert.ToInt32(this.txtEdad.Text);

            lista.Add(estudiantes);

            //mostrar los estudiantes en el listview
            ListViewItem item = new ListViewItem(estudiantes.NombreCompleto);
            listViewEstudiantes.Items.Add(item);
            item.SubItems.Add(estudiantes.Genero);
            item.SubItems.Add(estudiantes.EstadoCivil);
            item.SubItems.Add(estudiantes.edad.ToString());
        }
    }
}
