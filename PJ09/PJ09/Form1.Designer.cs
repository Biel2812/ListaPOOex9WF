namespace PJ09
{
    partial class frmNumeros
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
            this.lblNx = new System.Windows.Forms.Label();
            this.lblNy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumerox = new System.Windows.Forms.TextBox();
            this.txtNumeroy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNx
            // 
            this.lblNx.AutoSize = true;
            this.lblNx.Location = new System.Drawing.Point(598, 65);
            this.lblNx.Name = "lblNx";
            this.lblNx.Size = new System.Drawing.Size(52, 13);
            this.lblNx.TabIndex = 0;
            this.lblNx.Text = "Numero x";
            // 
            // lblNy
            // 
            this.lblNy.AutoSize = true;
            this.lblNy.Location = new System.Drawing.Point(598, 129);
            this.lblNy.Name = "lblNy";
            this.lblNy.Size = new System.Drawing.Size(52, 13);
            this.lblNy.TabIndex = 1;
            this.lblNy.Text = "Numero y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado  =  ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(706, 207);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(656, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // txtNumerox
            // 
            this.txtNumerox.Location = new System.Drawing.Point(656, 62);
            this.txtNumerox.Name = "txtNumerox";
            this.txtNumerox.Size = new System.Drawing.Size(75, 20);
            this.txtNumerox.TabIndex = 5;
            // 
            // txtNumeroy
            // 
            this.txtNumeroy.Location = new System.Drawing.Point(656, 126);
            this.txtNumeroy.Name = "txtNumeroy";
            this.txtNumeroy.Size = new System.Drawing.Size(75, 20);
            this.txtNumeroy.TabIndex = 6;
            // 
            // frmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.txtNumeroy);
            this.Controls.Add(this.txtNumerox);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNy);
            this.Controls.Add(this.lblNx);
            this.Name = "frmNumeros";
            this.Text = "Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNx;
        private System.Windows.Forms.Label lblNy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumerox;
        private System.Windows.Forms.TextBox txtNumeroy;
    }
}

