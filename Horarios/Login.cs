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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e) {
                    //Quando carrega o programa gera o banco
                    Mysql.conectar();
        }

       //Click do boão logar
        private void btn_Login_Click(object sender, EventArgs e) {
            //chamo o método já testando seu retorno
            //preenchendo os parâmetros necessários
            //se retorna true
            if (ValidaUsuario(txt_SenhaLogin.Text)) {
                //retorno o diálogo ok
                this.DialogResult = DialogResult.OK;
            } else {
                //Senão retorno o dialogo cancel por exemplo
                this.DialogResult = DialogResult.Cancel;
            }
        }

        //Método para validar usuário que recebe uma string
        //como parâmetro senha
        private bool ValidaUsuario(string senha) {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;
            ////instância da conexão
            MySqlConnection conn = new MySqlConnection(@"server=127.0.0.1;user id=root;Pwd=masterkey;persistsecurityinfo=True;database=bd_controle");
            //comando sql que dá um count 
            //na tabela se existir a senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM tb_usuarios WHERE senha=@senha";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@senha", senha);
            //abro conexão
            conn.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            conn.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;
        }
    }
}
    
