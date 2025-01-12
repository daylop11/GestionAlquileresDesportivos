namespace GestionAlquileresDesportivos.Vistas
{
    partial class Formulario_Equipos
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(105, 335);
            button3.Name = "button3";
            button3.Size = new Size(104, 60);
            button3.TabIndex = 20;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(120, 218);
            button2.Name = "button2";
            button2.Size = new Size(244, 29);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(120, 85);
            button1.Name = "button1";
            button1.Size = new Size(244, 29);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 187);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 15;
            label2.Text = "Listar equipo";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 67);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 14;
            label1.Text = "Agregar equipo";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(296, 335);
            button4.Name = "button4";
            button4.Size = new Size(103, 60);
            button4.TabIndex = 21;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = false;
            // 
            // Formulario_Equipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(484, 461);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formulario_Equipos";
            Text = "Formulario_Equipos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button4;
    }
}