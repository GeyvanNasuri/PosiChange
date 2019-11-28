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
    public partial class frm_historico : Form
    {
        public frm_historico()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange | Histórico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_historico_Load(object sender, EventArgs e)
        {
            Agendamento agenda = new Agendamento();
            Infracao infracao = new Infracao();
            //Infração
            var dri = infracao.Infracoes();
            DataTable dti = new DataTable();
            dti.Load(infracao.Infracoes());
            dgv_infracao.DataSource = dti;
            infracao.Patient = new Paciente();
            infracao.Nurse = new Enfermeiro();
            int linhaI = dgv_infracao.Rows.Count;
            foreach (var item in infracao.Infracoes())
            {
                dgv_infracao.Rows.Add();
                dgv_infracao.Rows[linhaI].Cells[0].Value = infracao.Infringement;
                dgv_infracao.Rows[linhaI].Cells[1].Value = infracao.Patient.Cod;
                dgv_infracao.Rows[linhaI].Cells[2].Value = infracao.Nurse.Cod ;
                dgv_infracao.Rows[linhaI].Cells[3].Value = infracao.Data;
                dgv_infracao.Rows[linhaI].Cells[4].Value = infracao.Nova;
            }
            //Agenda
            var dra = agenda.Agendas();
            DataTable dta = new DataTable();
            dta.Load(agenda.Agendas());
            dgv_infracao.DataSource = dta;
            infracao.Patient = new Paciente();
            agenda.Responsible = new Responsavel();
            int linhaA = dgv_infracao.Rows.Count;
            foreach (var item in agenda.Agendas())
            {
                dgv_infracao.Rows.Add();
                dgv_infracao.Rows[linhaA].Cells[0].Value = agenda.Responsible.Cod;
                dgv_infracao.Rows[linhaA].Cells[1].Value = agenda.Dia;
                dgv_infracao.Rows[linhaA].Cells[2].Value = agenda.Novo;
            }
        }
    }
}
