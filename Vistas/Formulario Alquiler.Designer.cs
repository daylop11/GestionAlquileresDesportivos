namespace GestionAlquileresDesportivos.Vistas
{
    partial class Formulario_Alquiler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnAlquiler = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 74);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 176);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 1;
            label2.Text = "Agregar informacion adicional";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 270);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 2;
            label3.Text = "Inquietudes del alquiler";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(53, 92);
            button1.Name = "button1";
            button1.Size = new Size(244, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(53, 194);
            button2.Name = "button2";
            button2.Size = new Size(244, 29);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAlquiler
            // 
            btnAlquiler.BackColor = Color.White;
            btnAlquiler.Location = new Point(53, 288);
            btnAlquiler.Name = "btnAlquiler";
            btnAlquiler.Size = new Size(244, 23);
            btnAlquiler.TabIndex = 5;
            btnAlquiler.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(207, 362);
            button3.Name = "button3";
            button3.Size = new Size(90, 41);
            button3.TabIndex = 6;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            // 
            // Formulario_Alquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(484, 461);
            Controls.Add(button3);
            Controls.Add(btnAlquiler);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formulario_Alquiler";
            Text = "Formulario_Alquiler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button btnAlquiler;
        private Button button3;
    }
}