namespace BibliotecaHerecia.Libros
{
    partial class VerLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLibros));
            btnBuscar = new Button();
            txtBoxBuscar = new TextBox();
            label1 = new Label();
            btnAgregar = new PictureBox();
            listaLibros = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(446, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 32);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar Libro";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(18, 43);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Escriba el nombre del libro";
            txtBoxBuscar.Size = new Size(412, 27);
            txtBoxBuscar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "Agregar Libro";
            label1.Click += iniciarCreacionLibro_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.InitialImage = Properties.Resources.agregar;
            btnAgregar.Location = new Point(650, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(47, 47);
            btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAgregar.TabIndex = 6;
            btnAgregar.TabStop = false;
            btnAgregar.Click += iniciarCreacionLibro_Click;
            // 
            // listaLibros
            // 
            listaLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listaLibros.Location = new Point(18, 108);
            listaLibros.Name = "listaLibros";
            listaLibros.Size = new Size(1208, 529);
            listaLibros.TabIndex = 5;
            // 
            // VerLibros
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1243, 667);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(listaLibros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerLibros";
            Text = "VerLibros";
            Activated += VerLibros_Activated;
            Load += VerLibros_Load;
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBoxBuscar;
        private Label label1;
        private PictureBox btnAgregar;
        private FlowLayoutPanel listaLibros;
    }
}