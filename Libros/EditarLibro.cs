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
    public partial class EditarLibro : Form
    {
        Libro libro;
        public EditarLibro(Libro libro)
        {
            InitializeComponent();
            this.libro = libro;
            if (libro is LibroFisico libroFisico)
            {
                mostrarCamposLibroFisico(libroFisico);
            }

            if (libro is LibroElectronico libroElectronico)
            {
                mostrarCamposLibroElectronico(libroElectronico);
            }
        }

        private void EditarLibro_Load(object sender, EventArgs e)
        {
            txtBoxTitulo.Text = libro.Titulo;
            txtBoxAutor.Text = libro.Autor;
            txtBoxAnio.Text = libro.AnioPublicacion.ToString();
            txtBoxISBN.Text = libro.ISBN;
            txtBoxGenero.Text = libro.Genero;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (libro is LibroFisico libroFisico)
            {
                AppState.Instance.bibliotecaActual.EditarLibro(libro.Id, new LibroFisico(txtBoxTitulo.Text, txtBoxAutor.Text, int.Parse(txtBoxAnio.Text), txtBoxISBN.Text, txtBoxGenero.Text, txtBoxUbicacion.Text));
            }

            if (libro is LibroElectronico libroElectronico)
            {
                AppState.Instance.bibliotecaActual.EditarLibro(libro.Id, new LibroElectronico(txtBoxTitulo.Text, txtBoxAutor.Text, int.Parse(txtBoxAnio.Text), txtBoxISBN.Text, txtBoxGenero.Text, txtBoxFormato.Text, txtBoxTamanio.Text));
            }

            this.Close();
        }

        private void mostrarCamposLibroFisico(LibroFisico libroFisico)
        {
            txtBoxFormato.Visible = false;
            labelFormato.Visible = false;
            txtBoxTamanio.Visible = false;
            labelTamanio.Visible = false;
            txtBoxUbicacion.Visible = true;
            labelUbicacion.Visible = true;
            txtBoxUbicacion.Text = libroFisico.Ubicacion;
        }

        private void mostrarCamposLibroElectronico(LibroElectronico libroElectronico)
        {
            txtBoxFormato.Visible = true;
            labelFormato.Visible = true;
            txtBoxTamanio.Visible = true;
            labelTamanio.Visible = true;
            txtBoxUbicacion.Visible = false;
            labelUbicacion.Visible = false;
            txtBoxFormato.Text = libroElectronico.Formato;
            txtBoxTamanio.Text = libroElectronico.Tamanio;
        }
    }
}
