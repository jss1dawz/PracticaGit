namespace ejercicioTelegrama
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
        ///  Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcularPrecio = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            rbUrgente = new RadioButton();
            rbOrdinario = new RadioButton();
            SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(461, 252);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(133, 64);
            btnCalcularPrecio.TabIndex = 0;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 76);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Texto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 274);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Coste:";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(106, 99);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(473, 110);
            txtTelegrama.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(160, 274);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 5;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(239, 228);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(83, 24);
            rbUrgente.TabIndex = 6;
            rbUrgente.TabStop = true;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Location = new Point(105, 228);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(93, 24);
            rbOrdinario.TabIndex = 7;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcularPrecio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPrecio;
        private Label label1;
        private Label label2;
        private TextBox txtTelegrama;
        private TextBox txtPrecio;
        private RadioButton rbUrgente;
        private RadioButton rbOrdinario;
    }
}
