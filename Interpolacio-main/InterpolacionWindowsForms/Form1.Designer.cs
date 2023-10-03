namespace InterpolacionWindowsForms
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
            tbPuntos = new TextBox();
            tbValorInterpolar = new TextBox();
            btnInterpolar = new Button();
            tbResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbPuntos
            // 
            tbPuntos.Location = new Point(321, 24);
            tbPuntos.Name = "tbPuntos";
            tbPuntos.Size = new Size(125, 27);
            tbPuntos.TabIndex = 0;
            // 
            // tbValorInterpolar
            // 
            tbValorInterpolar.Location = new Point(321, 115);
            tbValorInterpolar.Name = "tbValorInterpolar";
            tbValorInterpolar.Size = new Size(125, 27);
            tbValorInterpolar.TabIndex = 1;
            // 
            // btnInterpolar
            // 
            btnInterpolar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInterpolar.Location = new Point(510, 90);
            btnInterpolar.Name = "btnInterpolar";
            btnInterpolar.Size = new Size(110, 68);
            btnInterpolar.TabIndex = 2;
            btnInterpolar.Text = "INICIAR";
            btnInterpolar.UseVisualStyleBackColor = true;
            btnInterpolar.Click += btnInterpolar_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(321, 196);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(125, 27);
            tbResultado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(255, 30);
            label1.TabIndex = 4;
            label1.Text = "ESCRIBE LOS PUNTOS X,Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(226, 30);
            label2.TabIndex = 5;
            label2.Text = "VALOR A INTERPOLAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(223, 30);
            label3.TabIndex = 6;
            label3.Text = "VALOR INTERPOLADO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbResultado);
            Controls.Add(btnInterpolar);
            Controls.Add(tbValorInterpolar);
            Controls.Add(tbPuntos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPuntos;
        private TextBox tbValorInterpolar;
        private Button btnInterpolar;
        private TextBox tbResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}