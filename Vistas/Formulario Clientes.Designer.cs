namespace GestionAlquileresDesportivos.Vistas
{
    partial class Formulario_Clientes
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
            button3 = new Button();
            btnAlquiler = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(198, 352);
            button3.Name = "button3";
            button3.Size = new Size(90, 41);
            button3.TabIndex = 13;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAlquiler
            // 
            btnAlquiler.BackColor = Color.White;
            btnAlquiler.Location = new Point(120, 280);
            btnAlquiler.Name = "btnAlquiler";
            btnAlquiler.Size = new Size(244, 29);
            btnAlquiler.TabIndex = 12;
            btnAlquiler.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(120, 186);
            button2.Name = "button2";
            button2.Size = new Size(244, 29);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(120, 84);
            button1.Name = "button1";
            button1.Size = new Size(244, 29);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 262);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Cedula de identidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 168);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 8;
            label2.Text = "Numero de telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre del cliente";
            // 
            // Formulario_Clientes
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
            Name = "Formulario_Clientes";
            Text = "Formulario_Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button btnAlquiler;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}