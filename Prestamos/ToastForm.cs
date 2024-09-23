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

            toastX = screenwidth - this.Width - 10;
            toastY = screenheight - this.Height - 10;


            this.Location = new Point(toastX, toastY);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 900)
            {
                toastTimer.Stop();
                toastHide.Start();

            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();

                }
            }
        }
    }
}
