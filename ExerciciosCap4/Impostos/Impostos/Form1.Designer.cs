namespace Impostos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelValorNota = new System.Windows.Forms.Label();
            this.textBoxValorNota = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValorNota
            // 
            this.labelValorNota.AutoSize = true;
            this.labelValorNota.Location = new System.Drawing.Point(12, 9);
            this.labelValorNota.Name = "labelValorNota";
            this.labelValorNota.Size = new System.Drawing.Size(102, 13);
            this.labelValorNota.TabIndex = 0;
            this.labelValorNota.Text = "Valor da Nota Fiscal";
            // 
            // textBoxValorNota
            // 
            this.textBoxValorNota.Location = new System.Drawing.Point(15, 25);
            this.textBoxValorNota.Name = "textBoxValorNota";
            this.textBoxValorNota.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorNota.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(25, 51);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.buttonCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 84);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxValorNota);
            this.Controls.Add(this.labelValorNota);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impostos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorNota;
        private System.Windows.Forms.TextBox textBoxValorNota;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

