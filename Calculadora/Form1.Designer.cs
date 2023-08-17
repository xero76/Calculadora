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
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnExponente = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorA
            // 
            this.txtValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorA.Location = new System.Drawing.Point(26, 219);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(125, 37);
            this.txtValorA.TabIndex = 0;
            // 
            // txtValorB
            // 
            this.txtValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorB.Location = new System.Drawing.Point(25, 316);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(125, 37);
            this.txtValorB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor B";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(27, 71);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(414, 75);
            this.txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // brnSuma
            // 
            this.brnSuma.Image = ((System.Drawing.Image)(resources.GetObject("brnSuma.Image")));
            this.brnSuma.Location = new System.Drawing.Point(206, 170);
            this.brnSuma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brnSuma.Name = "brnSuma";
            this.brnSuma.Size = new System.Drawing.Size(86, 68);
            this.brnSuma.TabIndex = 6;
            this.brnSuma.UseVisualStyleBackColor = true;
            this.brnSuma.Click += new System.EventHandler(this.brnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Image = ((System.Drawing.Image)(resources.GetObject("btnResta.Image")));
            this.btnResta.Location = new System.Drawing.Point(355, 170);
            this.btnResta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(86, 68);
            this.btnResta.TabIndex = 7;
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiplicacion.Image")));
            this.btnMultiplicacion.Location = new System.Drawing.Point(206, 267);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(86, 71);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Image = ((System.Drawing.Image)(resources.GetObject("btnDivision.Image")));
            this.btnDivision.Location = new System.Drawing.Point(355, 267);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(88, 71);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnExponente
            // 
            this.btnExponente.Image = ((System.Drawing.Image)(resources.GetObject("btnExponente.Image")));
            this.btnExponente.Location = new System.Drawing.Point(206, 364);
            this.btnExponente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExponente.Name = "btnExponente";
            this.btnExponente.Size = new System.Drawing.Size(86, 69);
            this.btnExponente.TabIndex = 10;
            this.btnExponente.UseVisualStyleBackColor = true;
            this.btnExponente.Click += new System.EventHandler(this.btnExponente_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Image = ((System.Drawing.Image)(resources.GetObject("btnRaiz.Image")));
            this.btnRaiz.Location = new System.Drawing.Point(355, 364);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(88, 69);
            this.btnRaiz.TabIndex = 11;
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(357, 472);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(65, 472);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 31);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 519);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnExponente);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.brnSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

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