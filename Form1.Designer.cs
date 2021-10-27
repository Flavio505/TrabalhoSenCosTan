
namespace Trabalho_seno_cosseno_e_tangente
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbAngulo = new System.Windows.Forms.TextBox();
            this.lblSeno = new System.Windows.Forms.Label();
            this.lblCosseno = new System.Windows.Forms.Label();
            this.lblTangente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira um ângulo de até 360";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(44, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 26);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbAngulo
            // 
            this.txbAngulo.Location = new System.Drawing.Point(12, 65);
            this.txbAngulo.Name = "txbAngulo";
            this.txbAngulo.Size = new System.Drawing.Size(229, 20);
            this.txbAngulo.TabIndex = 2;
            // 
            // lblSeno
            // 
            this.lblSeno.AutoSize = true;
            this.lblSeno.Location = new System.Drawing.Point(16, 166);
            this.lblSeno.Name = "lblSeno";
            this.lblSeno.Size = new System.Drawing.Size(0, 13);
            this.lblSeno.TabIndex = 3;
            // 
            // lblCosseno
            // 
            this.lblCosseno.AutoSize = true;
            this.lblCosseno.Location = new System.Drawing.Point(16, 184);
            this.lblCosseno.Name = "lblCosseno";
            this.lblCosseno.Size = new System.Drawing.Size(0, 13);
            this.lblCosseno.TabIndex = 4;
            // 
            // lblTangente
            // 
            this.lblTangente.AutoSize = true;
            this.lblTangente.Location = new System.Drawing.Point(16, 200);
            this.lblTangente.Name = "lblTangente";
            this.lblTangente.Size = new System.Drawing.Size(0, 13);
            this.lblTangente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 235);
            this.Controls.Add(this.lblTangente);
            this.Controls.Add(this.lblCosseno);
            this.Controls.Add(this.lblSeno);
            this.Controls.Add(this.txbAngulo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbAngulo;
        private System.Windows.Forms.Label lblSeno;
        private System.Windows.Forms.Label lblCosseno;
        private System.Windows.Forms.Label lblTangente;
    }
}

