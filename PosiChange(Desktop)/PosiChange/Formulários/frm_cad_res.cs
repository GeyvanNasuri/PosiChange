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
    public partial class frm_cad_res : Form
    {
        public frm_cad_res()
        {
            InitializeComponent();
        }

        private void frm_cad_res_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Paciente paciente = new Paciente();
            var pacs = paciente.Pacientes();
            dt.Load(pacs);
            cmb_paciente.DataSource = dt;
            cmb_paciente.DisplayMember = "nome";
            cmb_paciente.ValueMember = "cod_pac";
            cmb_paciente.Text = "";
        }

        private void btn_cad_enf_Click(object sender, EventArgs e)
        {
            Responsavel responsavel = new Responsavel();
            responsavel.Nome = txt_nome.Text;
            responsavel.RG = txt_rg.Text;
            responsavel.CPF = txt_cpf.Text;
            responsavel.Senha = txt_senha.Text;
            responsavel.Telefone = txt_telefone.Text;
            responsavel.Email = txt_email.Text;
            responsavel.Acesso = true;
            responsavel.Patient = new Paciente();
            responsavel.Patient.Cod = Convert.ToInt32(cmb_paciente.SelectedValue);
            if (responsavel.Cod > 0)
            {
                var inseriu = MessageBox.Show("Paciente inserido com sucesso!", "PosiChange | Cadastro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (inseriu == DialogResult.OK)
                {
                    txt_nome.Clear();
                    txt_rg.Clear();
                    txt_cpf.Clear();
                    txt_telefone.Clear();
                    txt_email.Clear();
                    txt_senha.Clear();
                    cmb_paciente.Text = "";
                }
            }
        }

        private void btn_vol_enf_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
    "PosiChange | registro de Responsável", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
