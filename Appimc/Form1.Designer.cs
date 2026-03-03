namespace Appimc
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
            Altura = new Label();
            label2 = new Label();
            Peso = new Label();
            Kg = new Label();
            btCalcular = new Button();
            lblImc = new Label();
            lblClassif = new Label();
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            SuspendLayout();
            // 
            // Altura
            // 
            Altura.AutoSize = true;
            Altura.Font = new Font("Segoe UI", 12F);
            Altura.Location = new Point(236, 114);
            Altura.Name = "Altura";
            Altura.Size = new Size(52, 21);
            Altura.TabIndex = 0;
            Altura.Text = "Áltura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(654, 114);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 1;
            label2.Text = "m";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Font = new Font("Segoe UI", 12F);
            Peso.Location = new Point(243, 225);
            Peso.Name = "Peso";
            Peso.Size = new Size(45, 21);
            Peso.TabIndex = 2;
            Peso.Text = "Peso:";
            // 
            // Kg
            // 
            Kg.AutoSize = true;
            Kg.Font = new Font("Segoe UI", 12F);
            Kg.Location = new Point(654, 227);
            Kg.Name = "Kg";
            Kg.Size = new Size(28, 21);
            Kg.TabIndex = 3;
            Kg.Text = "Kg";
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 12F);
            btCalcular.Location = new Point(236, 282);
            btCalcular.Margin = new Padding(3, 4, 3, 4);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(466, 70);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "&Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // lblImc
            // 
            lblImc.AutoSize = true;
            lblImc.Font = new Font("Segoe UI", 12F);
            lblImc.Location = new Point(236, 414);
            lblImc.Name = "lblImc";
            lblImc.Size = new Size(0, 21);
            lblImc.TabIndex = 5;
            lblImc.Click += lblImc_Click;
            // 
            // lblClassif
            // 
            lblClassif.AutoSize = true;
            lblClassif.Font = new Font("Segoe UI", 12F);
            lblClassif.Location = new Point(236, 496);
            lblClassif.Name = "lblClassif";
            lblClassif.Size = new Size(0, 21);
            lblClassif.TabIndex = 6;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Font = new Font("Segoe UI", 12F);
            numAltura.Location = new Point(294, 112);
            numAltura.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(359, 29);
            numAltura.TabIndex = 7;
            numAltura.ValueChanged += numAltura_ValueChanged;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Font = new Font("Segoe UI", 12F);
            numPeso.Location = new Point(294, 225);
            numPeso.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(359, 29);
            numPeso.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 556);
            Controls.Add(numPeso);
            Controls.Add(numAltura);
            Controls.Add(lblClassif);
            Controls.Add(lblImc);
            Controls.Add(btCalcular);
            Controls.Add(Kg);
            Controls.Add(Peso);
            Controls.Add(label2);
            Controls.Add(Altura);
            Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "CalculadoraDeImc";
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Altura;
        private Label label2;
        private Label Peso;
        private Label Kg;
        private Button btCalcular;
        private Label lblImc;
        private Label lblClassif;
        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
    }
}
