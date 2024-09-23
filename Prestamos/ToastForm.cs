using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaHerecia.Prestamos
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;

        public ToastForm()
        {
            InitializeComponent();
        }

        // Evento que se dispara al cargar el formulario
        private void ToastForm_Load(object sender, EventArgs e)
        {
            // Posicionar el formulario en la esquina inferior derecha
            PositionToast();
        }

        // Método para posicionar el formulario en la esquina inferior derecha
        private void PositionToast()
        {
            int screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenheight = Screen.PrimaryScreen.WorkingArea.Height;

            // Ajustamos las coordenadas para que esté cerca del borde inferior derecho
            toastX = screenwidth - this.Width - 10;  // Ajuste con un pequeño margen
            toastY = screenheight - this.Height - 10; // Ajuste con un pequeño margen

            // Asignamos la nueva posición
            this.Location = new Point(toastX, toastY);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Manejo de eventos para label1 (puedes personalizarlo según tu necesidad)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Manejo de eventos para label2 (puedes personalizarlo según tu necesidad)
        }
    }
}
