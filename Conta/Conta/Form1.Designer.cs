namespace Conta
{
    partial class Form1
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
            this.buttonSaldo = new System.Windows.Forms.Button();
            this.buttonSaque = new System.Windows.Forms.Button();
            this.buttonDeposito = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelConta = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.Location = new System.Drawing.Point(12, 88);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(75, 23);
            this.buttonSaldo.TabIndex = 0;
            this.buttonSaldo.Text = "Saldo";
            this.buttonSaldo.UseVisualStyleBackColor = true;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // buttonSaque
            // 
            this.buttonSaque.Location = new System.Drawing.Point(93, 88);
            this.buttonSaque.Name = "buttonSaque";
            this.buttonSaque.Size = new System.Drawing.Size(75, 23);
            this.buttonSaque.TabIndex = 1;
            this.buttonSaque.Text = "Sacar";
            this.buttonSaque.UseVisualStyleBackColor = true;
            this.buttonSaque.Click += new System.EventHandler(this.buttonSaque_Click);
            // 
            // buttonDeposito
            // 
            this.buttonDeposito.Location = new System.Drawing.Point(174, 88);
            this.buttonDeposito.Name = "buttonDeposito";
            this.buttonDeposito.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposito.TabIndex = 3;
            this.buttonDeposito.Text = "Depositar";
            this.buttonDeposito.UseVisualStyleBackColor = true;
            this.buttonDeposito.Click += new System.EventHandler(this.buttonDeposito_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 46);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(12, 62);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 5;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.Location = new System.Drawing.Point(12, 9);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(35, 13);
            this.labelConta.TabIndex = 6;
            this.labelConta.Text = "label1";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(12, 27);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(35, 13);
            this.labelOwner.TabIndex = 7;
            this.labelOwner.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 123);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelConta);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.buttonDeposito);
            this.Controls.Add(this.buttonSaque);
            this.Controls.Add(this.buttonSaldo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaldo;
        private System.Windows.Forms.Button buttonSaque;
        private System.Windows.Forms.Button buttonDeposito;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.Label labelOwner;
    }
}

