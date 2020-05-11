namespace Inicio
{
    partial class Tela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.TxtCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Location = new System.Drawing.Point(122, 100);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 39);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(122, 12);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(174, 20);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.Text = "Altura";
            this.txtAltura.TextChanged += new System.EventHandler(this.txt01_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(93, 163);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(244, 45);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "RESULTADO";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(122, 47);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(174, 20);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.Text = "Peso";
            // 
            // TxtCalcular
            // 
            this.TxtCalcular.Location = new System.Drawing.Point(213, 100);
            this.TxtCalcular.Name = "TxtCalcular";
            this.TxtCalcular.Size = new System.Drawing.Size(83, 39);
            this.TxtCalcular.TabIndex = 11;
            this.TxtCalcular.Text = "Calcular";
            this.TxtCalcular.UseVisualStyleBackColor = true;
            this.TxtCalcular.Click += new System.EventHandler(this.TxtCalcular_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(456, 247);
            this.Controls.Add(this.TxtCalcular);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tela";
            this.Text = "Calculador de IMC";
            this.Load += new System.EventHandler(this.Tela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button TxtCalcular;
    }
}

