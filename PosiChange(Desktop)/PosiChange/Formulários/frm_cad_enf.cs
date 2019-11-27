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
using PosiChange.Formulários;

namespace PosiChange.Formulários
{
    public partial class frm_cad_enf : Form
    {
        public frm_cad_enf()
        {
            InitializeComponent();
        }

        private void Cad_Enf_Load(object sender, EventArgs e)
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

        private void btn_vol_enf_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
                "PosiChange | Novo Enfermeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ver_enf_Click(object sender, EventArgs e)
        {
            var enf = new Enfermeiro();

            if (txt_coren.Text != String.Empty)
            {
                //enf.VerificarCoren(Convert.ToInt32(txt_coren_cad_enf.Text));
                if (Convert.ToInt32(txt_coren.Text) == enf.Coren)
                {
                    MessageBox.Show("Este Coren ja está em uso!", "PosiChange | Cadastro de Enfermeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_coren.Clear();
                    txt_coren.Focus();
                }

                if (Convert.ToInt32(txt_coren.Text) != enf.Coren)
                {
                    btn_cadastrar.Enabled = true;
                }
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Enfermeiro enfermeiro = new Enfermeiro();
            enfermeiro.Nome = txt_nome.Text;
            enfermeiro.RG = txt_rg.Text;
            enfermeiro.CPF = txt_cpf.Text;
            enfermeiro.Coren = Convert.ToInt32(txt_coren.Text);
            enfermeiro.Turno = cmb_turno.Text;
            enfermeiro.Intervalo = Convert.ToDateTime(txt_intervalo.Text);
            enfermeiro.Telefone = txt_telefone.Text;
            enfermeiro.Level = new Nivel();
            enfermeiro.Level.Cod = Convert.ToInt32(cmb_nivel.SelectedValue);
            enfermeiro.Inserir();
            if (enfermeiro.Cod > 0)
            {
                var inseriu = MessageBox.Show("Enfermeiro inserido com sucesso!", "PosiChange | Cadastro de Enfermeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (inseriu == DialogResult.OK)
                {
                    txt_nome.Clear();
                    txt_rg.Clear();
                    txt_cpf.Clear();
                    txt_telefone.Clear();
                    cmb_nivel.Text = "";
                    txt_coren.Clear();
                    txt_intervalo.Clear();
                    cmb_turno.Text = "";
                }
            }
        }
    }
}