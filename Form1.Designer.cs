namespace GestionAlquileresDesportivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 64);
            label1.Name = "label1";
            label1.Size = new Size(289, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos al sitema de alquiler";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 141);
            button1.Name = "button1";
            button1.Size = new Size(120, 56);
            button1.TabIndex = 1;
            button1.Text = "Alquileres";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(302, 141);
            button2.Name = "button2";
            button2.Size = new Size(120, 56);
            button2.TabIndex = 2;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(185, 286);
            button3.Name = "button3";
            button3.Size = new Size(120, 56);
            button3.TabIndex = 3;
            button3.Text = "Equipos";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-7, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 471);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(484, 461);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario Principal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
    }
}
