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

namespace BibliotecaHerecia.Prestamos
{
    public partial class RealizarPrestamo : Form
    {
        public RealizarPrestamo()
        {
            InitializeComponent();
            inicializarMiembros();
            inicializarTiposLibro();
            inicializarLibros();
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            Miembro miembroSeleccionado = (Miembro)miembrosComboBox.SelectedItem;
            Libro libroSeleccionado = (Libro)librosComboBox.SelectedItem;
            Prestamo nuevoPrestamo = new Prestamo(DateTime.Now, fechaDevolucionDatePicker.Value, libroSeleccionado, miembroSeleccionado);
            AppState.Instance.bibliotecaActual.RealizarPrestamo(nuevoPrestamo);

            MessageBox.Show($"Prestamo {nuevoPrestamo.Id} realizado con éxito, hay {AppState.Instance.bibliotecaActual.prestamos.Count()} prestamos actualmente");
            this.Close();
        }

        private void inicializarMiembros()
        {
            miembrosComboBox.DataSource = AppState.Instance.bibliotecaActual.miembros;
            miembrosComboBox.DisplayMember = "Nombre";
            miembrosComboBox.ValueMember = "Id";
        }

        private void inicializarTiposLibro()
        {
            tipoLibroComboBox.Items.Add("Físico");
            tipoLibroComboBox.Items.Add("Electrónico");
            tipoLibroComboBox.SelectedIndex = 0;
        }

        private void inicializarLibros()
        {
            string tipoLibroSeleccionado = tipoLibroComboBox.SelectedItem.ToString() == "Físico" ? "LibroFisico" : "LibroElectronico";
            librosComboBox.DataSource = AppState.Instance.bibliotecaActual.libros.Where(libro => libro.GetType().Name == tipoLibroSeleccionado).ToList();
            librosComboBox.DisplayMember = "Titulo";
            librosComboBox.ValueMember = "Id";
        }

        private void tipoLibroComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            inicializarLibros();
        }
    }
}
