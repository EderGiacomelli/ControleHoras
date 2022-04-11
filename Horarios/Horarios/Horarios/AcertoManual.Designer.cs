
namespace Horarios {
    partial class AcertoManual {
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
            this.txt_HoraAcerto = new System.Windows.Forms.MaskedTextBox();
            this.txt_DataAcerto = new System.Windows.Forms.MaskedTextBox();
            this.cmb_UserAcerto = new System.Windows.Forms.ComboBox();
            this.btn_AcertoSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_EntradaSaida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_HoraAcerto
            // 
            this.txt_HoraAcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_HoraAcerto.Location = new System.Drawing.Point(93, 92);
            this.txt_HoraAcerto.Mask = "00:00";
            this.txt_HoraAcerto.Name = "txt_HoraAcerto";
            this.txt_HoraAcerto.Size = new System.Drawing.Size(44, 24);
            this.txt_HoraAcerto.TabIndex = 1;
            this.txt_HoraAcerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HoraAcerto.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DataAcerto
            // 
            this.txt_DataAcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_DataAcerto.Location = new System.Drawing.Point(77, 30);
            this.txt_DataAcerto.Mask = "00/00/0000";
            this.txt_DataAcerto.Name = "txt_DataAcerto";
            this.txt_DataAcerto.Size = new System.Drawing.Size(84, 24);
            this.txt_DataAcerto.TabIndex = 0;
            this.txt_DataAcerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DataAcerto.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_UserAcerto
            // 
            this.cmb_UserAcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_UserAcerto.FormattingEnabled = true;
            this.cmb_UserAcerto.Location = new System.Drawing.Point(58, 145);
            this.cmb_UserAcerto.Name = "cmb_UserAcerto";
            this.cmb_UserAcerto.Size = new System.Drawing.Size(121, 26);
            this.cmb_UserAcerto.TabIndex = 2;
            // 
            // btn_AcertoSalvar
            // 
            this.btn_AcertoSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AcertoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcertoSalvar.Location = new System.Drawing.Point(81, 232);
            this.btn_AcertoSalvar.Name = "btn_AcertoSalvar";
            this.btn_AcertoSalvar.Size = new System.Drawing.Size(78, 31);
            this.btn_AcertoSalvar.TabIndex = 4;
            this.btn_AcertoSalvar.Text = "Salvar";
            this.btn_AcertoSalvar.UseVisualStyleBackColor = false;
            this.btn_AcertoSalvar.Click += new System.EventHandler(this.btn_AcertoSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            // 
            // cmb_EntradaSaida
            // 
            this.cmb_EntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_EntradaSaida.FormattingEnabled = true;
            this.cmb_EntradaSaida.Location = new System.Drawing.Point(60, 200);
            this.cmb_EntradaSaida.Name = "cmb_EntradaSaida";
            this.cmb_EntradaSaida.Size = new System.Drawing.Size(121, 26);
            this.cmb_EntradaSaida.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Entrada ou saída:";
            // 
            // AcertoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(238, 285);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_EntradaSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AcertoSalvar);
            this.Controls.Add(this.cmb_UserAcerto);
            this.Controls.Add(this.txt_DataAcerto);
            this.Controls.Add(this.txt_HoraAcerto);
            this.Name = "AcertoManual";
            this.Text = "AcertoManual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_HoraAcerto;
        private System.Windows.Forms.MaskedTextBox txt_DataAcerto;
        private System.Windows.Forms.ComboBox cmb_UserAcerto;
        private System.Windows.Forms.Button btn_AcertoSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_EntradaSaida;
        private System.Windows.Forms.Label label4;
    }
}