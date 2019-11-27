using PosiChange.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosiChange.Formulários
{
    public partial class frm_cad_ate : Form
    {
        public frm_cad_ate()
        {
            InitializeComponent();
        }

        private void frm_cad_ate_Load(object sender, EventArgs e)
        {
            btn_cadastrar.Enabled = false;
            // Sem um mysql.datareader isto não rola!
            DataTable dt = new DataTable();
            Nivel nivel = new Nivel();
            var niveis = nivel.Niveis();
            dt.Load(niveis);
            cmb_nivel.DataSource = dt;
            cmb_nivel.DisplayMember = "nivel";
            cmb_nivel.ValueMember = "cod_nivel";
            cmb_nivel.Text = "";
            cmb_turno.Text = "";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Nome = txt_nome.Text;
            atendente.RG = txt_rg.Text;
            atendente.CPF = txt_cpf.Text;
            atendente.Login = txt_login.Text;
            atendente.Senha = txt_senha.Text;
            atendente.Intervalo = Convert.ToDateTime(txt_intervalo.Text);
            atendente.Turno = cmb_turno.Text;
            atendente.Telefone = txt_telefone.Text;
            atendente.Acesso = rbt_acesso.Checked;
            atendente.Level = new Nivel();
            atendente.Level.Cod = Convert.ToInt32(cmb_nivel.SelectedValue);
            atendente.Inserir();
            if (atendente.Cod > 0)
            {
                var inseriu = MessageBox.Show("Usuario inserido com sucesso!", "PosiChange | Cadastro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (inseriu == DialogResult.OK)
                {
                    txt_telefone.Clear();
                    cmb_turno.Text = "";
                    txt_intervalo.Clear();
                    txt_senha.Clear();
                    txt_login.Clear();
                    txt_cpf.Clear();
                    txt_rg.Clear();
                    txt_cpf.Clear();
                    txt_nome.Clear();
                    cmb_nivel.Text = "";
                }
                
            }
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            if (atendente.Login == txt_login.Text)
            {
                var existe = MessageBox.Show("Este Login já está em uso!", "PosiChange | Cadastro de Atendente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (existe == DialogResult.OK)
                {
                    txt_login.Clear();
                    txt_login.Focus();
                }
            }
            else if (atendente.Login != txt_login.Text)
            {
                btn_cadastrar.Enabled = true;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
                  "PosiChange | Cadastro de Atendente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
