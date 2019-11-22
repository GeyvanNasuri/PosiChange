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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();
            atendente.Nome = txt_nome.Text;
            atendente.RG = txt_rg.Text;
            atendente.CPF = txt_cpf.Text;
            atendente.Login = txt_login.Text;
            atendente.Senha = txt_senha.Text;
            atendente.Intervalo = Convert.ToDateTime(txt_intervalo.Text);
            atendente.Turno = txt_turno.Text;
            atendente.Telefone = txt_telefone.Text;
            atendente.Acesso = rbt_acesso.Checked;
            atendente.Level.Cod = Convert.ToInt32(cmb_nivel.Text);
        }
    }
}
