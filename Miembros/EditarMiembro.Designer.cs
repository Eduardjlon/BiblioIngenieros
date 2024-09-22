namespace BibliotecaHerecia.Miembros
{
    partial class EditarMiembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMiembro));
            txtBoxNumero = new TextBox();
            txtBoxNombre = new TextBox();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxNumero
            // 
            txtBoxNumero.Location = new Point(197, 113);
            txtBoxNumero.Name = "txtBoxNumero";
            txtBoxNumero.PlaceholderText = "Escriba el número del miembro";
            txtBoxNumero.Size = new Size(283, 27);
            txtBoxNumero.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(197, 173);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxNombre.Size = new Size(283, 27);
            txtBoxNombre.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(232, 240);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(84, 106);
            label1.Name = "label1";
            label1.Size = new Size(89, 42);
            label1.TabIndex = 3;
            label1.Text = "Número de Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 180);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 29);
            label3.Name = "label3";
            label3.Size = new Size(350, 28);
            label3.TabIndex = 5;
            label3.Text = "Actualizar Información de Miembro";
            // 
            // EditarMiembro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 319);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxNumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditarMiembro";
            Text = "EditarMiembro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNumero;
        private TextBox txtBoxNombre;
        private Button btnActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}