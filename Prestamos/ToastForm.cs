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

        private void ToastForm_Load(object sender, EventArgs e)
        {
            // Posicionar el formulario en la esquina inferior derecha
            PositionToast();
        }

        private void PositionToast()
        {
            int screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenheight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = screenwidth - this.Width - 10;  // Ajuste con un pequeño margen
            toastY = screenheight - this.Height - 10; // Ajuste con un pequeño margen

         
            this.Location = new Point(toastX, toastY);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
