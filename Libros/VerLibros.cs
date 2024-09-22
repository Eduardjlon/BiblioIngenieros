using BibliotecaHerecia.Clases;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Miembros;
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
    public partial class VerLibros : Form
    {
        public VerLibros()
        {
            InitializeComponent();
        }

        private Panel crearTarjetaLibro(Libro libro)
        {
            Panel panelTarjeta = new Panel();
            panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
            panelTarjeta.Padding = new Padding(10);
            panelTarjeta.Margin = new Padding(10);
            panelTarjeta.BackColor = Color.LightGray;
            panelTarjeta.Size = new Size(200, 150);

            Label lblInfo = new Label();
            lblInfo.Text = $"{libro.Titulo} \n{libro.Autor} \n{libro.GetType().Name}";
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Arial", 10, FontStyle.Regular);
            lblInfo.Padding = new Padding(5);

            Button btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.AutoSize = true;
            btnEditar.Location = new Point(10, 100);
            btnEditar.Click += (sender, e) =>
            {
                EditarLibro editarLibro = new EditarLibro(libro);
                editarLibro.ShowDialog();
            };

            Button btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(90, 100);
            btnEliminar.Click += (sender, e) =>
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este libro?", "Eliminar libro", botones);
                if (resultado == DialogResult.No) return;
                AppState.Instance.bibliotecaActual.EliminarLibro(libro);
                renderizarLibros();
            };

            panelTarjeta.Controls.Add(lblInfo);
            panelTarjeta.Controls.Add(btnEditar);
            panelTarjeta.Controls.Add(btnEliminar);

            return panelTarjeta;
        }

        private void renderizarLibros()
        {
            listaLibros.Controls.Clear();
            AppState.Instance.bibliotecaActual.libros.Where(libro => libro.Titulo.Contains(txtBoxBuscar.Text)).ToList().ForEach(libro =>
            {
                listaLibros.Controls.Add(crearTarjetaLibro(libro));
            });
            listaLibros.AutoScroll = true;
        }

        private void VerLibros_Load(object sender, EventArgs e)
        {
            renderizarLibros();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            renderizarLibros();
        }

        private void VerLibros_Activated(object sender, EventArgs e)
        {
            renderizarLibros();
        }

        private void iniciarCreacionLibro_Click(object sender, EventArgs e)
        {
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog();
        }
    }
}
