using BibliotecaHerecia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia.Libros
{
    public partial class NuevoLibro : Form
    {
        public NuevoLibro()
        {
            InitializeComponent();
            tipoLibro.Items.Add("Físico");
            tipoLibro.Items.Add("Electrónico");
            tipoLibro.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (tipoLibro.SelectedItem == "Físico")
            {
                AppState.Instance.bibliotecaActual.AgregarLibro(new LibroFisico(txtBoxTitulo.Text, txtBoxAutor.Text, int.Parse(txtBoxAnio.Text), txtBoxISBN.Text, txtBoxGenero.Text, txtBoxUbicacion.Text));
            }
            else
            {
                AppState.Instance.bibliotecaActual.AgregarLibro(new LibroElectronico(txtBoxTitulo.Text, txtBoxAutor.Text, int.Parse(txtBoxAnio.Text), txtBoxISBN.Text, txtBoxGenero.Text, txtBoxFormato.Text, txtBoxTamanio.Text));
            }

            this.Close();
        }

        private void mostrarCamposLibroFisico()
        {
            txtBoxFormato.Visible = false;
            labelFormato.Visible = false;
            txtBoxTamanio.Visible = false;
            labelTamanio.Visible = false;
            txtBoxUbicacion.Visible = true;
            labelUbicacion.Visible = true;
        }

        private void mostrarCamposLibroElectronico()
        {
            txtBoxFormato.Visible = true;
            labelFormato.Visible = true;
            txtBoxTamanio.Visible = true;
            labelTamanio.Visible = true;
            txtBoxUbicacion.Visible = false;
            labelUbicacion.Visible = false;
        }

        private void tipoLibro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tipoLibro.SelectedItem == "Físico")
            {
                mostrarCamposLibroFisico();
            }
            else
            {
                mostrarCamposLibroElectronico();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
