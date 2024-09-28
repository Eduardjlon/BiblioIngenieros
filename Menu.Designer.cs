namespace BibliotecaHerecia
{
    partial class Menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelSideMenu = new Panel();
            panelPrestamoSubMenu = new Panel();
            botonPrestamo = new Button();
            Prestamo = new Button();
            panelLibrosSubMenu = new Panel();
            botonLibros = new Button();
            btonLibros = new Button();
            panelMiembrosSubMenu = new Panel();
            botonMiembros = new Button();
            Miembro = new Button();
            panelLogo = new Panel();
            panelContenido = new Panel();
            panelSideMenu.SuspendLayout();
            panelPrestamoSubMenu.SuspendLayout();
            panelLibrosSubMenu.SuspendLayout();
            panelMiembrosSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(panelPrestamoSubMenu);
            panelSideMenu.Controls.Add(Prestamo);
            panelSideMenu.Controls.Add(panelLibrosSubMenu);
            panelSideMenu.Controls.Add(btonLibros);
            panelSideMenu.Controls.Add(panelMiembrosSubMenu);
            panelSideMenu.Controls.Add(Miembro);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(2, 3, 2, 3);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(222, 561);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelFondo_Paint;
            // 
            // panelPrestamoSubMenu
            // 
            panelPrestamoSubMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelPrestamoSubMenu.Controls.Add(botonPrestamo);
            panelPrestamoSubMenu.Dock = DockStyle.Top;
            panelPrestamoSubMenu.Location = new Point(0, 344);
            panelPrestamoSubMenu.Margin = new Padding(2, 3, 2, 3);
            panelPrestamoSubMenu.Name = "panelPrestamoSubMenu";
            panelPrestamoSubMenu.Size = new Size(222, 43);
            panelPrestamoSubMenu.TabIndex = 5;
            // 
            // botonPrestamo
            // 
            botonPrestamo.Dock = DockStyle.Top;
            botonPrestamo.FlatAppearance.BorderSize = 0;
            botonPrestamo.FlatAppearance.MouseDownBackColor = Color.Red;
            botonPrestamo.FlatAppearance.MouseOverBackColor = Color.Blue;
            botonPrestamo.FlatStyle = FlatStyle.Flat;
            botonPrestamo.ForeColor = Color.White;
            botonPrestamo.Location = new Point(0, 0);
            botonPrestamo.Margin = new Padding(2, 3, 2, 3);
            botonPrestamo.Name = "botonPrestamo";
            botonPrestamo.Padding = new Padding(31, 0, 0, 0);
            botonPrestamo.Size = new Size(222, 40);
            botonPrestamo.TabIndex = 0;
            botonPrestamo.Text = "Solicitar Prestamo";
            botonPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            botonPrestamo.UseVisualStyleBackColor = true;
            botonPrestamo.Click += botonPrestamo_Click;
            // 
            // Prestamo
            // 
            Prestamo.Dock = DockStyle.Top;
            Prestamo.FlatAppearance.BorderSize = 0;
            Prestamo.FlatAppearance.MouseDownBackColor = Color.Red;
            Prestamo.FlatAppearance.MouseOverBackColor = Color.Blue;
            Prestamo.FlatStyle = FlatStyle.Flat;
            Prestamo.ForeColor = Color.White;
            Prestamo.Location = new Point(0, 299);
            Prestamo.Margin = new Padding(2, 3, 2, 3);
            Prestamo.Name = "Prestamo";
            Prestamo.Padding = new Padding(9, 0, 0, 0);
            Prestamo.Size = new Size(222, 45);
            Prestamo.TabIndex = 4;
            Prestamo.Text = "Prestamos";
            Prestamo.TextAlign = ContentAlignment.MiddleLeft;
            Prestamo.UseVisualStyleBackColor = true;
            Prestamo.Click += Prestamo_Click;
            // 
            // panelLibrosSubMenu
            // 
            panelLibrosSubMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelLibrosSubMenu.Controls.Add(botonLibros);
            panelLibrosSubMenu.Dock = DockStyle.Top;
            panelLibrosSubMenu.Location = new Point(0, 258);
            panelLibrosSubMenu.Margin = new Padding(2, 3, 2, 3);
            panelLibrosSubMenu.Name = "panelLibrosSubMenu";
            panelLibrosSubMenu.Size = new Size(222, 41);
            panelLibrosSubMenu.TabIndex = 3;
            // 
            // botonLibros
            // 
            botonLibros.Dock = DockStyle.Top;
            botonLibros.FlatAppearance.BorderSize = 0;
            botonLibros.FlatAppearance.MouseDownBackColor = Color.Red;
            botonLibros.FlatAppearance.MouseOverBackColor = Color.Blue;
            botonLibros.FlatStyle = FlatStyle.Flat;
            botonLibros.ForeColor = Color.White;
            botonLibros.Location = new Point(0, 0);
            botonLibros.Margin = new Padding(2, 3, 2, 3);
            botonLibros.Name = "botonLibros";
            botonLibros.Padding = new Padding(31, 0, 0, 0);
            botonLibros.Size = new Size(222, 40);
            botonLibros.TabIndex = 0;
            botonLibros.Text = "Administrar Libros";
            botonLibros.TextAlign = ContentAlignment.MiddleLeft;
            botonLibros.UseVisualStyleBackColor = true;
            botonLibros.Click += botonLibros_Click;
            // 
            // btonLibros
            // 
            btonLibros.Dock = DockStyle.Top;
            btonLibros.FlatAppearance.BorderSize = 0;
            btonLibros.FlatAppearance.MouseDownBackColor = Color.Red;
            btonLibros.FlatAppearance.MouseOverBackColor = Color.Blue;
            btonLibros.FlatStyle = FlatStyle.Flat;
            btonLibros.ForeColor = Color.White;
            btonLibros.Location = new Point(0, 213);
            btonLibros.Margin = new Padding(2, 3, 2, 3);
            btonLibros.Name = "btonLibros";
            btonLibros.Padding = new Padding(9, 0, 0, 0);
            btonLibros.Size = new Size(222, 45);
            btonLibros.TabIndex = 2;
            btonLibros.Text = "Libros";
            btonLibros.TextAlign = ContentAlignment.MiddleLeft;
            btonLibros.UseVisualStyleBackColor = true;
            btonLibros.Click += btonLibros_Click;
            // 
            // panelMiembrosSubMenu
            // 
            panelMiembrosSubMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMiembrosSubMenu.Controls.Add(botonMiembros);
            panelMiembrosSubMenu.Dock = DockStyle.Top;
            panelMiembrosSubMenu.Location = new Point(0, 172);
            panelMiembrosSubMenu.Margin = new Padding(2, 3, 2, 3);
            panelMiembrosSubMenu.Name = "panelMiembrosSubMenu";
            panelMiembrosSubMenu.Size = new Size(222, 41);
            panelMiembrosSubMenu.TabIndex = 1;
            // 
            // botonMiembros
            // 
            botonMiembros.Dock = DockStyle.Top;
            botonMiembros.FlatAppearance.BorderSize = 0;
            botonMiembros.FlatAppearance.MouseDownBackColor = Color.Red;
            botonMiembros.FlatAppearance.MouseOverBackColor = Color.Blue;
            botonMiembros.FlatStyle = FlatStyle.Flat;
            botonMiembros.ForeColor = Color.White;
            botonMiembros.Location = new Point(0, 0);
            botonMiembros.Margin = new Padding(2, 3, 2, 3);
            botonMiembros.Name = "botonMiembros";
            botonMiembros.Padding = new Padding(31, 0, 0, 0);
            botonMiembros.Size = new Size(222, 40);
            botonMiembros.TabIndex = 0;
            botonMiembros.Text = "Administrar Miembros";
            botonMiembros.TextAlign = ContentAlignment.MiddleLeft;
            botonMiembros.UseVisualStyleBackColor = true;
            botonMiembros.Click += Miembros_Click;
            // 
            // Miembro
            // 
            Miembro.Dock = DockStyle.Top;
            Miembro.FlatAppearance.BorderSize = 0;
            Miembro.FlatAppearance.MouseDownBackColor = Color.Red;
            Miembro.FlatAppearance.MouseOverBackColor = Color.Blue;
            Miembro.FlatStyle = FlatStyle.Flat;
            Miembro.ForeColor = Color.White;
            Miembro.Location = new Point(0, 127);
            Miembro.Margin = new Padding(2, 3, 2, 3);
            Miembro.Name = "Miembro";
            Miembro.Padding = new Padding(9, 0, 0, 0);
            Miembro.Size = new Size(222, 45);
            Miembro.TabIndex = 0;
            Miembro.Text = "Miembros";
            Miembro.TextAlign = ContentAlignment.MiddleLeft;
            Miembro.UseVisualStyleBackColor = true;
            Miembro.Click += Miembro_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Red;
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 3, 2, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(222, 127);
            panelLogo.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.AutoSize = true;
            panelContenido.BackgroundImageLayout = ImageLayout.None;
            panelContenido.Location = new Point(226, 0);
            panelContenido.Margin = new Padding(2, 3, 2, 3);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(941, 561);
            panelContenido.TabIndex = 1;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1168, 561);
            Controls.Add(panelContenido);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Menu";
            Text = "Biblioteca";
            panelSideMenu.ResumeLayout(false);
            panelPrestamoSubMenu.ResumeLayout(false);
            panelLibrosSubMenu.ResumeLayout(false);
            panelMiembrosSubMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelSideMenu;
        private Panel panelContenido; // Panel añadido
        private Panel panelPrestamoSubMenu;
        private Button botonPrestamo;
        private Button Prestamo;
        private Panel panelLibrosSubMenu;
        private Button botonLibros;
        private Button btonLibros;
        private Panel panelMiembrosSubMenu;
        private Button botonMiembros;
        private Button Miembro;
        private Panel panelLogo;
    }
}
//Modificacion de dimensiones
