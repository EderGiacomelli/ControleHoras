
namespace Horarios {
    partial class AlterarSenha {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txt_SenhaAtual = new System.Windows.Forms.TextBox();
            this.txt_Confirmar = new System.Windows.Forms.TextBox();
            this.txt_NovaSenha = new System.Windows.Forms.TextBox();
            this.btn_AlteraSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_SenhaAtual
            // 
            this.txt_SenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_SenhaAtual.Location = new System.Drawing.Point(74, 87);
            this.txt_SenhaAtual.MaxLength = 4;
            this.txt_SenhaAtual.Name = "txt_SenhaAtual";
            this.txt_SenhaAtual.Size = new System.Drawing.Size(100, 24);
            this.txt_SenhaAtual.TabIndex = 1;
            this.txt_SenhaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Confirmar
            // 
            this.txt_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Confirmar.Location = new System.Drawing.Point(74, 197);
            this.txt_Confirmar.MaxLength = 4;
            this.txt_Confirmar.Name = "txt_Confirmar";
            this.txt_Confirmar.Size = new System.Drawing.Size(100, 24);
            this.txt_Confirmar.TabIndex = 3;
            this.txt_Confirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_NovaSenha
            // 
            this.txt_NovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_NovaSenha.Location = new System.Drawing.Point(74, 140);
            this.txt_NovaSenha.MaxLength = 4;
            this.txt_NovaSenha.Name = "txt_NovaSenha";
            this.txt_NovaSenha.Size = new System.Drawing.Size(100, 24);
            this.txt_NovaSenha.TabIndex = 2;
            this.txt_NovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AlteraSenha
            // 
            this.btn_AlteraSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_AlteraSenha.Location = new System.Drawing.Point(79, 227);
            this.btn_AlteraSenha.Name = "btn_AlteraSenha";
            this.btn_AlteraSenha.Size = new System.Drawing.Size(86, 33);
            this.btn_AlteraSenha.TabIndex = 4;
            this.btn_AlteraSenha.Text = "Alterar";
            this.btn_AlteraSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(79, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(52, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cofirmar Nova Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(78, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(76, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF Usuário:";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_CPF.Location = new System.Drawing.Point(69, 30);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(112, 24);
            this.txt_CPF.TabIndex = 0;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(241, 273);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AlteraSenha);
            this.Controls.Add(this.txt_NovaSenha);
            this.Controls.Add(this.txt_Confirmar);
            this.Controls.Add(this.txt_SenhaAtual);
            this.Name = "AlterarSenha";
            this.Text = "AlterarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SenhaAtual;
        private System.Windows.Forms.TextBox txt_Confirmar;
        private System.Windows.Forms.TextBox txt_NovaSenha;
        private System.Windows.Forms.Button btn_AlteraSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
    }
}