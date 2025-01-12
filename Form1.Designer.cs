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
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
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
            button1.Text = "Nombre del cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(302, 141);
            button2.Name = "button2";
            button2.Size = new Size(120, 56);
            button2.TabIndex = 2;
            button2.Text = "Telefono";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(46, 251);
            button3.Name = "button3";
            button3.Size = new Size(120, 56);
            button3.TabIndex = 3;
            button3.Text = "Fecha Alquiler";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(302, 251);
            button4.Name = "button4";
            button4.Size = new Size(120, 56);
            button4.TabIndex = 4;
            button4.Text = "Fecha Devolucion";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 210);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 5;
            label2.Text = "Insertar nombre del cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 210);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 6;
            label3.Text = "Insertar numero telefonico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 327);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 7;
            label4.Text = "Ingresar fecha de inicio";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 327);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 8;
            label5.Text = "Ingresar fecha  de devolucion";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
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
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
