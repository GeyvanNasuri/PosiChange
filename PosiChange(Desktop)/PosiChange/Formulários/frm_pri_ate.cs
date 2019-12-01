using System;
using PosiChange.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosiChange.Formulários;

namespace PosiChange.Formulários
{
    public partial class frm_pri_ate : Form
    {
        public frm_pri_ate()
        {
            InitializeComponent();
        }

        private void Principal_Aten_Load(object sender, EventArgs e)
        {
            /*Infracao inf = new Infracao();
            Agendamento age = new Agendamento();
            if (inf.Ocorrencia() == true)
            {
                btn_notificacao.BackColor = Color.Red;
                btn_infracao.BackColor = Color.Red;
            }
            else if (inf.Ocorrencia() == false)
            {
                btn_notificacao.BackColor = Color.Transparent;
                btn_infracao.BackColor = Color.Transparent;
            }
            if (age.Agenda() == true)
            {
                btn_notificacao.BackColor = Color.Yellow;
                btn_agendamento.BackColor = Color.Yellow;
            }
            else if (age.Agenda() == false)
            {
                btn_notificacao.BackColor = Color.Transparent;
                btn_agendamento.BackColor = Color.Transparent;
            }*/

        }

        private void btn_cad_enf_Click(object sender, EventArgs e)
        {
            frm_cad_enf enf = new frm_cad_enf();
            enf.MdiParent = this;
            enf.Show();
        }

        private void btn_con_enf_Click(object sender, EventArgs e)
        {
            //frm_con_enf enf = new frm_con_enf();
            //enf.MdiParent = this;
            //enf.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_cad_pac_Click(object sender, EventArgs e)
        {
            frm_cad_pac pac = new frm_cad_pac();
            pac.MdiParent = this;
            pac.Show();
        }

        private void btn_con_pac_Click(object sender, EventArgs e)
        {
            //frm_con_pac pac = new frm_con_pac();
            //pac.MdiParent = this;
            //pac.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_reg_res_Click(object sender, EventArgs e)
        {
            frm_cad_res res = new frm_cad_res();
            res.MdiParent = this;
            res.Show();
        }

        private void btn_quarto_Click(object sender, EventArgs e)
        {
            //frm_quarto quarto = new frm_quarto();
            //quarto.MdiParent = this;
            //quarto.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            //frm_historico historico = new frm_historico();
            //historico.MdiParent = this;
            //historico.Show();
            MessageBox.Show("Sinto Muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_monitor_Click(object sender, EventArgs e)
        {
            //frm_monitor monitor = new frm_monitor();
            //monitor.MdiParent = this;
            //monitor.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_infracao_Click(object sender, EventArgs e)
        {
            //frm_infracao infracao = new frm_infracao();
            //infracao.MdiParent = this;
            //infracao.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_agendamento_Click_1(object sender, EventArgs e)
        {            
            //frm_agenda agenda = new frm_agenda();
            //agenda.MdiParent = this;
            //agenda.Show();
            MessageBox.Show("Sinto muito, mas esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                // comando para fecha um formalario enquanto carrega outro!
                this.Hide();
                Form formL = new frm_login();
                formL.Closed += (s, args) => this.Close();
                formL.Show();
            }
        }

    }
}