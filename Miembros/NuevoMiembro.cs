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
    public partial class NuevoMiembro : Form
    {
        public NuevoMiembro()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Miembro nuevoMiembro = new Miembro(txtBoxNombre.Text, int.Parse(txtBoxNumero.Text));
            AppState.Instance.bibliotecaActual.AgregarMiembro(nuevoMiembro);
            this.Close();
        }
    }
}
