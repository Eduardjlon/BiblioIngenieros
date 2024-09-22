using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        // Miembros
        private void CustomizeDesign()
        {
            panelMiembrosSubMenu.Visible = false;
            panelLibrosSubMenu.Visible = false;
            panelPrestamoSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMiembrosSubMenu.Visible)
                panelMiembrosSubMenu.Visible = false;
            if (panelLibrosSubMenu.Visible)
                panelLibrosSubMenu.Visible = false;
            if (panelPrestamoSubMenu.Visible)
                panelPrestamoSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Miembro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMiembrosSubMenu);
        }

        private void Miembros_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VerMiembros());
        }

        // Libros
        private void botonLibros_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VerLibros());
        }

        private void btonLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibrosSubMenu);
        }

        // Préstamos
        private void botonPrestamo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RealizarPrestamo());
        }

        private void Prestamo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamoSubMenu);
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            panelContenido.Controls.Clear(); // Limpiar el panel de contenido
            formulario.TopLevel = false; // No es un formulario independiente
            formulario.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formulario.Dock = DockStyle.Fill; // Llenar el panel
            panelContenido.Controls.Add(formulario); // Añadir el formulario al panel
            formulario.Show(); // Mostrar el formulario
        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
