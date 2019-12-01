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
    public partial class frm_cad_pac : Form
    {
        public frm_cad_pac()
        {
            InitializeComponent();
        }

        private void Cad_Pac_Load(object sender, EventArgs e)
        {
            txt_descricao.Enabled = false;
            rbt_nao.Checked = true;
        }

        private void rbt_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim.Checked)
            {
                txt_descricao.Enabled = true;
            }
        }

        private void btn_cad_enf_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                paciente.Nome = txt_nome.Text;
                paciente.RG = txt_rg.Text;
                paciente.CPF = txt_cpf.Text;
                paciente.Ferida = rbt_sim.Checked || false;
                paciente.Descricao = txt_descricao.Text;
                paciente.Situacao = txt_situacao.Text;
                paciente.Insert();
                if (paciente.Cod > 0)
                {
                    var inseriu = MessageBox.Show("Paciente inserido com sucesso!",
                        "PosiChange | Cadastro de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (inseriu == DialogResult.OK)
                    {
                        txt_nome.Clear();
                        txt_rg.Clear();
                        txt_cpf.Clear();
                        txt_descricao.Clear();
                        txt_situacao.Clear();
                    }
                }
            }
            catch (Exception ex)
            {

                //throw ex;
                var erro = MessageBox.Show("Sinto muito, RG e/ou CPF já em uso, por favor verifique",
                    "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (erro == DialogResult.OK)
                {
                    txt_rg.Clear();
                    txt_cpf.Clear();
                    txt_rg.Focus();
                    txt_cpf.Focus();
                }
            }
        }

        private void btn_vol_enf_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
                "PosiChange | Cadastro de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbt_nao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao.Checked)
            {
                txt_descricao.Enabled = false;
            }
        }
    }
}
