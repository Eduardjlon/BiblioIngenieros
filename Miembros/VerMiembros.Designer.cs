namespace BibliotecaHerecia.Miembros
{
    partial class VerMiembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMiembros));
            listaMiembros = new FlowLayoutPanel();
            btnAgregar = new PictureBox();
            label1 = new Label();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            SuspendLayout();
            // 
            // listaMiembros
            // 
            listaMiembros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listaMiembros.Location = new Point(25, 116);
            listaMiembros.Name = "listaMiembros";
            listaMiembros.Size = new Size(1089, 529);
            listaMiembros.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.InitialImage = Properties.Resources.agregar;
            btnAgregar.Location = new Point(661, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(47, 47);
            btnAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAgregar.TabIndex = 1;
            btnAgregar.TabStop = false;
            btnAgregar.Click += iniciarCreacionMiembro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(714, 48);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 2;
            label1.Text = "Agregar Miembro";
            label1.Click += iniciarCreacionMiembro_Click;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(25, 51);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxBuscar.Size = new Size(412, 27);
            txtBoxBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(469, 48);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 32);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar Miembro";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // VerMiembros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 677);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(listaMiembros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerMiembros";
            Text = "VerMiembros";
            Activated += VerMiembros_Activated;
            Load += VerMiembros_Load;
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel listaMiembros;
        private PictureBox btnAgregar;
        private Label label1;
        private TextBox txtBoxBuscar;
        private Button btnBuscar;
    }
}