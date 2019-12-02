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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

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
            try
            {
                Atendente atendente = new Atendente();
                atendente.Level = new Nivel();
                if (atendente.EfetuarLogin(txt_usuario_login.Text, txt_senha_login.Text) == true)
                {
                    if (atendente.Level.Cod == 1 || atendente.Level.Cod == 2)
                    {
                        if (atendente.Acesso == true)
                        {
                            this.Hide();
                            Form formD = new frm_pri_adm();
                            formD.Closed += (s, args) => this.Close();
                            formD.Show();
                        }

                        else if (atendente.Acesso == false)
                        {
                            this.Hide();
                            Form formD = new frm_pri_adm();
                            formD.Closed += (s, args) => this.Close();
                            formD.Show();
                        }
                    }
                    if (atendente.Level.Cod == 3)
                    {
                        if (atendente.Acesso == true)
                        {
                            this.Hide();
                            Form formA = new frm_pri_ate();
                            formA.Closed += (s, args) => this.Close();
                            formA.Show();
                        }

                        else if (atendente.Acesso == false)
                        {
                            this.Hide();
                            Form formA = new frm_pri_ate();
                            formA.Closed += (s, args) => this.Close();
                            formA.Show();
                        }
                    }
                }
                else if (atendente.EfetuarLogin(txt_usuario_login.Text, txt_senha_login.Text) == false)
                {
                    MessageBox.Show("Login e/ou senha inexistente", "PosiChange",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                //throw ex;
                MessageBox.Show("Sem conexão com a rede, por favor verifique!", "PosiChange",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
