using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosiChange.Classes;

namespace PosiChange.Formulários
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_entrar_login_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            if (atendente.EfetuarLogin(txt_usuario_login.Text, txt_senha_login.Text) == true && atendente.Cod > 0)
            {
                if (atendente.Level.Cod == 1 || atendente.Level.Cod == 2)
                {
                    Principal_Adm adm = new Principal_Adm();
                    adm.ShowDialog();
                    Login login = new Login();
                    login.Hide();
                }
                if (atendente.Level.Cod == 2)
                {
                    Principal_Aten aten = new Principal_Aten();
                    aten.ShowDialog();
                    Login login = new Login();
                    login.Hide();
                }
            }
            if (atendente.EfetuarLogin(txt_usuario_login.Text, txt_senha_login.Text) == false)
            {
                MessageBox.Show("Login e/ou senha incoenrente", "PosiChange",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
