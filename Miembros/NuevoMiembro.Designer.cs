namespace BibliotecaHerecia.Miembros
{
    partial class NuevoMiembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMiembro));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCrear = new Button();
            txtBoxNombre = new TextBox();
            txtBoxNumero = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 20);
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 11;
            label3.Text = "Crear Nuevo Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 171);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.Location = new Point(68, 97);
            label1.Name = "label1";
            label1.Size = new Size(89, 42);
            label1.TabIndex = 9;
            label1.Text = "Número de Miembro";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(216, 231);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(181, 164);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxNombre.Size = new Size(283, 27);
            txtBoxNombre.TabIndex = 7;
            // 
            // txtBoxNumero
            // 
            txtBoxNumero.Location = new Point(181, 104);
            txtBoxNumero.Name = "txtBoxNumero";
            txtBoxNumero.PlaceholderText = "Escriba el número del miembro";
            txtBoxNumero.Size = new Size(283, 27);
            txtBoxNumero.TabIndex = 6;
            // 
            // NuevoMiembro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 331);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxNumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoMiembro";
            Text = "NuevoMiembro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCrear;
        private TextBox txtBoxNombre;
        private TextBox txtBoxNumero;
    }
}