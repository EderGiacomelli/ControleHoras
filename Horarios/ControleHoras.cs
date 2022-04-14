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
    public partial class ControleHoras : Form {
        public ControleHoras() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
           
        }

        private void timer1_Tick(object sender, EventArgs e) {
            maskedTextBox2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ControleHoras_Load(object sender, EventArgs e) {
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void txt_EntraSai_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Text.Length == 1) {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_senha_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Text.Length == 4) {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
