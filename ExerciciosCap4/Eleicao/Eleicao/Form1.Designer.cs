namespace Eleicao
{
    partial class Form_Principal
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
            this.button_Verificar = new System.Windows.Forms.Button();
            this.label_idade = new System.Windows.Forms.Label();
            this.checkBox_brasileiro = new System.Windows.Forms.CheckBox();
            this.textBox_idade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Verificar
            // 
            this.button_Verificar.Location = new System.Drawing.Point(33, 78);
            this.button_Verificar.Name = "button_Verificar";
            this.button_Verificar.Size = new System.Drawing.Size(75, 23);
            this.button_Verificar.TabIndex = 3;
            this.button_Verificar.Text = "Verificar";
            this.button_Verificar.UseVisualStyleBackColor = true;
            this.button_Verificar.Click += new System.EventHandler(this.button_Verificar_Click);
            // 
            // label_idade
            // 
            this.label_idade.AutoSize = true;
            this.label_idade.Location = new System.Drawing.Point(5, 9);
            this.label_idade.Name = "label_idade";
            this.label_idade.Size = new System.Drawing.Size(34, 13);
            this.label_idade.TabIndex = 1;
            this.label_idade.Text = "Idade";
            // 
            // checkBox_brasileiro
            // 
            this.checkBox_brasileiro.AutoSize = true;
            this.checkBox_brasileiro.Location = new System.Drawing.Point(8, 51);
            this.checkBox_brasileiro.Name = "checkBox_brasileiro";
            this.checkBox_brasileiro.Size = new System.Drawing.Size(68, 17);
            this.checkBox_brasileiro.TabIndex = 2;
            this.checkBox_brasileiro.Text = "Brasileiro";
            this.checkBox_brasileiro.UseVisualStyleBackColor = true;
            // 
            // textBox_idade
            // 
            this.textBox_idade.Location = new System.Drawing.Point(8, 25);
            this.textBox_idade.Name = "textBox_idade";
            this.textBox_idade.Size = new System.Drawing.Size(118, 20);
            this.textBox_idade.TabIndex = 1;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 113);
            this.Controls.Add(this.textBox_idade);
            this.Controls.Add(this.checkBox_brasileiro);
            this.Controls.Add(this.label_idade);
            this.Controls.Add(this.button_Verificar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posso votar?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Verificar;
        private System.Windows.Forms.Label label_idade;
        private System.Windows.Forms.CheckBox checkBox_brasileiro;
        private System.Windows.Forms.TextBox textBox_idade;
    }
}

