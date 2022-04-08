
namespace ControleHoras {
    partial class Frm_EntradaeSaida {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Cb_EnterExit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(37, 164);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(100, 23);
            this.Txt_Usuario.TabIndex = 0;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(37, 226);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(100, 23);
            this.Txt_Senha.TabIndex = 1;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Cb_EnterExit
            // 
            this.Cb_EnterExit.FormattingEnabled = true;
            this.Cb_EnterExit.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.Cb_EnterExit.Location = new System.Drawing.Point(37, 90);
            this.Cb_EnterExit.Name = "Cb_EnterExit";
            this.Cb_EnterExit.Size = new System.Drawing.Size(121, 23);
            this.Cb_EnterExit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o evento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuário:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_Salvar.FlatAppearance.BorderSize = 2;
            this.Btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Salvar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Btn_Salvar.Location = new System.Drawing.Point(37, 283);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(83, 33);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Frm_EntradaeSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 338);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_EnterExit);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Usuario);
            this.Name = "Frm_EntradaeSaida";
            this.Text = "Entrada e Saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.ComboBox Cb_EnterExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Salvar;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

