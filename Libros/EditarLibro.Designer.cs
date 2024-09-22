namespace BibliotecaHerecia.Libros
{
    partial class EditarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarLibro));
            label3 = new Label();
            label2 = new Label();
            btnActualizar = new Button();
            txtBoxTitulo = new TextBox();
            label4 = new Label();
            txtBoxAutor = new TextBox();
            label5 = new Label();
            txtBoxAnio = new TextBox();
            label6 = new Label();
            txtBoxGenero = new TextBox();
            label7 = new Label();
            txtBoxISBN = new TextBox();
            labelFormato = new Label();
            txtBoxFormato = new TextBox();
            labelTamanio = new Label();
            txtBoxTamanio = new TextBox();
            labelUbicacion = new Label();
            txtBoxUbicacion = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 23);
            label3.Name = "label3";
            label3.Size = new Size(318, 28);
            label3.TabIndex = 11;
            label3.Text = "Actualizar Información del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 100);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 10;
            label2.Text = "Título";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(197, 556);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.Location = new Point(184, 93);
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.PlaceholderText = "Escriba el título del libro";
            txtBoxTitulo.Size = new Size(283, 27);
            txtBoxTitulo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 165);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 13;
            label4.Text = "Autor";
            // 
            // txtBoxAutor
            // 
            txtBoxAutor.Location = new Point(184, 158);
            txtBoxAutor.Name = "txtBoxAutor";
            txtBoxAutor.PlaceholderText = "Escriba el nombre del autor";
            txtBoxAutor.Size = new Size(283, 27);
            txtBoxAutor.TabIndex = 12;
            // 
            // label5
            // 
            label5.Location = new Point(71, 224);
            label5.Name = "label5";
            label5.Size = new Size(89, 40);
            label5.TabIndex = 15;
            label5.Text = "Año de Publicación";
            // 
            // txtBoxAnio
            // 
            txtBoxAnio.Location = new Point(184, 230);
            txtBoxAnio.Name = "txtBoxAnio";
            txtBoxAnio.PlaceholderText = "Escriba el año de publicación del libro";
            txtBoxAnio.Size = new Size(283, 27);
            txtBoxAnio.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 379);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 19;
            label6.Text = "Genero";
            // 
            // txtBoxGenero
            // 
            txtBoxGenero.Location = new Point(184, 372);
            txtBoxGenero.Name = "txtBoxGenero";
            txtBoxGenero.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxGenero.Size = new Size(283, 27);
            txtBoxGenero.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 309);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 17;
            label7.Text = "ISBN";
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(184, 302);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.PlaceholderText = "Escriba el ISBN del libro";
            txtBoxISBN.Size = new Size(283, 27);
            txtBoxISBN.TabIndex = 16;
            // 
            // labelFormato
            // 
            labelFormato.AutoSize = true;
            labelFormato.Location = new Point(71, 445);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(65, 20);
            labelFormato.TabIndex = 21;
            labelFormato.Text = "Formato";
            // 
            // txtBoxFormato
            // 
            txtBoxFormato.Location = new Point(184, 438);
            txtBoxFormato.Name = "txtBoxFormato";
            txtBoxFormato.PlaceholderText = "Escriba el formato del libro";
            txtBoxFormato.Size = new Size(283, 27);
            txtBoxFormato.TabIndex = 20;
            // 
            // labelTamanio
            // 
            labelTamanio.AutoSize = true;
            labelTamanio.Location = new Point(71, 515);
            labelTamanio.Name = "labelTamanio";
            labelTamanio.Size = new Size(61, 20);
            labelTamanio.TabIndex = 23;
            labelTamanio.Text = "Tamaño";
            // 
            // txtBoxTamanio
            // 
            txtBoxTamanio.Location = new Point(184, 508);
            txtBoxTamanio.Name = "txtBoxTamanio";
            txtBoxTamanio.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxTamanio.Size = new Size(283, 27);
            txtBoxTamanio.TabIndex = 22;
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(71, 449);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(75, 20);
            labelUbicacion.TabIndex = 25;
            labelUbicacion.Text = "Ubicación";
            // 
            // txtBoxUbicacion
            // 
            txtBoxUbicacion.Location = new Point(184, 442);
            txtBoxUbicacion.Name = "txtBoxUbicacion";
            txtBoxUbicacion.PlaceholderText = "Escriba la ubicación del libro";
            txtBoxUbicacion.Size = new Size(283, 27);
            txtBoxUbicacion.TabIndex = 24;
            // 
            // EditarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 608);
            Controls.Add(labelUbicacion);
            Controls.Add(txtBoxUbicacion);
            Controls.Add(labelTamanio);
            Controls.Add(txtBoxTamanio);
            Controls.Add(labelFormato);
            Controls.Add(txtBoxFormato);
            Controls.Add(label6);
            Controls.Add(txtBoxGenero);
            Controls.Add(label7);
            Controls.Add(txtBoxISBN);
            Controls.Add(label5);
            Controls.Add(txtBoxAnio);
            Controls.Add(label4);
            Controls.Add(txtBoxAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(txtBoxTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditarLibro";
            Text = "EditarLibro";
            Load += EditarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btnActualizar;
        private TextBox txtBoxTitulo;
        private Label label4;
        private TextBox txtBoxAutor;
        private Label label5;
        private TextBox txtBoxAnio;
        private Label label6;
        private TextBox txtBoxGenero;
        private Label label7;
        private TextBox txtBoxISBN;
        private Label labelFormato;
        private TextBox txtBoxFormato;
        private Label labelTamanio;
        private TextBox txtBoxTamanio;
        private Label labelUbicacion;
        private TextBox txtBoxUbicacion;
    }
}