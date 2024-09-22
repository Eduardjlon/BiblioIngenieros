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
    public partial class EditarMiembro : Form
    {
        Miembro miembro;
        public EditarMiembro(Miembro miembro)
        {
            InitializeComponent();
            this.miembro = miembro;
            txtBoxNombre.Text = miembro.Nombre;
            txtBoxNumero.Text = miembro.NumeroMiembro.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Miembro miembroModificado = new Miembro(txtBoxNombre.Text, int.Parse(txtBoxNumero.Text));
            AppState.Instance.bibliotecaActual.EditarMiembro(miembro.Id, miembroModificado);
            this.Close();
        }
    }
}
