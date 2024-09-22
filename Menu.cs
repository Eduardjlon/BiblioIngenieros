using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelLibrosSubMenu.Visible = false;
            panelMiembrosSubMenu.Visible = false;
            panelPrestamoSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelLibrosSubMenu.Visible == true)
                panelLibrosSubMenu.Visible = false;
            if (panelMiembrosSubMenu.Visible == true)
                panelMiembrosSubMenu.Visible = false;
            if (panelPrestamoSubMenu.Visible == true)
                panelPrestamoSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
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
        private void ShowLibro(Panel panelMiembros)
        {
            throw new NotImplementedException();
        }

        private void Miembros_Click(object sender, EventArgs e)
        {
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();
        }

        private void botonLibros_Click(object sender, EventArgs e)
        {
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();
        }

        private void botonPrestamo_Click(object sender, EventArgs e)
        {
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();

        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btonLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLibrosSubMenu);
        }

        private void Prestamo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamoSubMenu);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}