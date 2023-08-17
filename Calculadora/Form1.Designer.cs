namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            txtValorA = new TextBox();
            txtValorB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtResultado = new TextBox();
            label3 = new Label();
            brnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnExponente = new Button();
            btnRaiz = new Button();
            btnExit = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtValorA
            // 
            txtValorA.Font = new Font("Digital-7", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorA.Location = new Point(23, 164);
            txtValorA.Margin = new Padding(3, 2, 3, 2);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new Size(135, 31);
            txtValorA.TabIndex = 0;
            // 
            // txtValorB
            // 
            txtValorB.Font = new Font("Digital-7", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorB.Location = new Point(22, 237);
            txtValorB.Margin = new Padding(3, 2, 3, 2);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(136, 31);
            txtValorB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 147);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 220);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor B";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Digital-7", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(24, 53);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(290, 55);
            txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(24, 23);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // brnSuma
            // 
            brnSuma.Image = (Image)resources.GetObject("brnSuma.Image");
            brnSuma.Location = new Point(180, 157);
            brnSuma.Name = "brnSuma";
            brnSuma.Size = new Size(55, 51);
            brnSuma.TabIndex = 2;
            brnSuma.UseVisualStyleBackColor = true;
            brnSuma.Click += brnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Image = (Image)resources.GetObject("btnResta.Image");
            btnResta.Location = new Point(259, 158);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(55, 51);
            btnResta.TabIndex = 3;
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Image = (Image)resources.GetObject("btnMultiplicacion.Image");
            btnMultiplicacion.Location = new Point(180, 229);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(55, 53);
            btnMultiplicacion.TabIndex = 5;
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Image = (Image)resources.GetObject("btnDivision.Image");
            btnDivision.Location = new Point(259, 230);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(55, 53);
            btnDivision.TabIndex = 6;
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnExponente
            // 
            btnExponente.Image = (Image)resources.GetObject("btnExponente.Image");
            btnExponente.Location = new Point(332, 158);
            btnExponente.Name = "btnExponente";
            btnExponente.Size = new Size(55, 52);
            btnExponente.TabIndex = 4;
            btnExponente.UseVisualStyleBackColor = true;
            btnExponente.Click += btnExponente_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Image = (Image)resources.GetObject("btnRaiz.Image");
            btnRaiz.Location = new Point(332, 229);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(55, 52);
            btnRaiz.TabIndex = 7;
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.salir;
            btnExit.Location = new Point(332, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(55, 52);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.limpiar;
            btnReset.Location = new Point(332, 53);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(55, 55);
            btnReset.TabIndex = 8;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 389);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnRaiz);
            Controls.Add(btnExponente);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(brnSuma);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValorB);
            Controls.Add(txtValorA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorA;
        private TextBox txtValorB;
        private Label label1;
        private Label label2;
        private TextBox txtResultado;
        private Label label3;
        private Button brnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnExponente;
        private Button btnRaiz;
        private Button btnExit;
        private Button btnReset;
    }
}