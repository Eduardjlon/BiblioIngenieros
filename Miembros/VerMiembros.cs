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

namespace BibliotecaHerecia.Miembros
{
    public partial class VerMiembros : Form
    {
        public VerMiembros()
        {
            InitializeComponent();
        }

        private void VerMiembros_Load(object sender, EventArgs e)
        {
            renderizarMiembros();
        }

        private Panel crearTarjetaMiembro(Miembro miembro)
        {
            // Crear un panel para contener la tarjeta
            Panel panelTarjeta = new Panel();
            panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
            panelTarjeta.Padding = new Padding(10);
            panelTarjeta.Margin = new Padding(10);
            panelTarjeta.BackColor = Color.LightGray;
            panelTarjeta.Size = new Size(200, 150); // Tamaño fijo para la tarjeta

            // Agregar información del miembro
            Label lblInfo = new Label();
            lblInfo.Text = $"{miembro.NumeroMiembro} \n{miembro.Nombre}";
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Arial", 10, FontStyle.Regular);
            lblInfo.Padding = new Padding(5);

            // Botón de editar
            Button btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.AutoSize = true;
            btnEditar.Location = new Point(10, 100);
            btnEditar.Click += (sender, e) =>
            {
                EditarMiembro editarMiembro = new EditarMiembro(miembro);
                editarMiembro.ShowDialog();
            };

            // Botón de eliminar
            Button btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(90, 100);
            btnEliminar.Click += (sender, e) =>
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este miembro?", "Eliminar miembro", botones);
                if (resultado == DialogResult.No) return;
                AppState.Instance.bibliotecaActual.EliminarMiembro(miembro);
                renderizarMiembros();
            };

            // Agregar controles al panel de la tarjeta
            panelTarjeta.Controls.Add(lblInfo);
            panelTarjeta.Controls.Add(btnEditar);
            panelTarjeta.Controls.Add(btnEliminar);

            return panelTarjeta;
        }

        private void renderizarMiembros()
        {
            listaMiembros.Controls.Clear();
            AppState.Instance.bibliotecaActual.miembros.Where(miembro => miembro.Nombre.Contains(txtBoxBuscar.Text)).ToList().ForEach(miembro =>
            {
                listaMiembros.Controls.Add(crearTarjetaMiembro(miembro));
            });
            listaMiembros.AutoScroll = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            renderizarMiembros();
        }

        private void VerMiembros_Activated(object sender, EventArgs e)
        {
            renderizarMiembros();
        }

        private void iniciarCreacionMiembro_Click(object sender, EventArgs e)
        {
            NuevoMiembro nuevoMiembro = new NuevoMiembro();
            nuevoMiembro.ShowDialog();
        }
    }
}
