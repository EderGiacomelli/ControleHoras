using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horarios {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        //Botão acessar que verifica login e inicializa o programa
        private void btn_Login_Click(object sender, EventArgs e) {
            
            //Abre a tela Principal e fecha o login
            this.Hide();
            Principal tela = new Principal();
            tela.Closed += (s, args) => this.Close();
            tela.Show();

        }
    }
}
