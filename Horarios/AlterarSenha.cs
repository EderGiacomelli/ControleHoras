using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Horarios {
    public partial class AlterarSenha : Form {
        public AlterarSenha() {
            InitializeComponent();
        }

        private void btn_AlteraSenha_Click(object sender, EventArgs e) {
            if (txt_NovaSenha.Text == txt_Confirmar.Text && txt_Confirmar.Text.Length == 4) {
                try {

                    string MyConnection2 = @"server=127.0.0.1;user id=root;Pwd=masterkey;persistsecurityinfo=True;database=bd_controle";
                    string Query = "UPDATE tb_usuarios SET senha='" + this.txt_Confirmar.Text + "' WHERE senha ='" + this.txt_SenhaAtual.Text + "'; ";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Senha Alterada");
                    while (MyReader2.Read()) {
                    }
                    MyConn2.Close();

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            } else {
                MessageBox.Show("As senhas estão diferentes, ou curtas");
            }

        }
    }
}
