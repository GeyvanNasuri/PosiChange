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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
            
            else if (respota == DialogResult.No)
            {
                var Logout = MessageBox.Show("Deseja então deslogar do sistema?", "PosiChange",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Logout == DialogResult.Yes)
                {
                    frm_pri_ate aten = new frm_pri_ate();
                    frm_login login = new frm_login();
                    
                    login.Show();
                }
                this.Close();
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_enf enf = new frm_cad_enf();
            enf.MdiParent = this;
            enf.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_con_enf enf = new frm_con_enf();
            enf.MdiParent = this;
            enf.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_cad_pac pac = new frm_cad_pac();
            pac.MdiParent = this;
            pac.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_con_pac pac = new frm_con_pac();
            pac.MdiParent = this;
            pac.Show();
        }

        private void infraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_infracao infracao = new frm_infracao();
            infracao.MdiParent = this;
            infracao.Show();
        }

        private void resgistrarResponsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_res res = new frm_cad_res();
            res.MdiParent = this;
            res.Show();
        }

        private void btn_agendamento_Click(object sender, EventArgs e)
        {
            frm_agenda agenda = new frm_agenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_quarto quarto = new frm_quarto();
            quarto.MdiParent = this;
            quarto.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_historico historico = new frm_historico();
            historico.MdiParent = this;
            historico.Show();
        }

        private void monitoramentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_monitor monitor = new frm_monitor();
            monitor.MdiParent = this;
            monitor.Show();
        }
    }
}