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
    public partial class frm_con_enf : Form
    {
        public frm_con_enf()
        {
            InitializeComponent();
        }

        private void dgv_informacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Enfermeiro enf = new Enfermeiro();
            if (txt_nome.Text != String.Empty)
            {
                var dr = enf.ListaEnfermeiro(txt_nome.Text);
                DataTable dt = new DataTable();
                //dt.Load(dr);
                dgv_informacoes.DataSource = dr;
                foreach (var item in enf.ListaEnfermeiro(txt_nome.Text))
                {
                    int linha = dgv_informacoes.Rows.Count;
                    dgv_informacoes.Rows.Add();
                    dgv_informacoes.Rows[linha].Cells[0].Value = enf.Nome;
                    dgv_informacoes.Rows[linha].Cells[1].Value = enf.RG;
                    dgv_informacoes.Rows[linha].Cells[2].Value = enf.CPF;
                    dgv_informacoes.Rows[linha].Cells[3].Value = enf.Coren;
                    dgv_informacoes.Rows[linha].Cells[4].Value = enf.Intervalo;
                    dgv_informacoes.Rows[linha].Cells[5].Value = enf.Turno;
                    dgv_informacoes.Rows[linha].Cells[6].Value = enf.Telefone;
                    dgv_informacoes.Rows[linha].Cells[7].Value = enf.Level.Level;
                }
            }
            else if (txt_nome.Text == String.Empty)
            {
                var dr = enf.TodosEnfermeiro();
                DataTable dt = new DataTable();
                //dt.Load(dr);
                dgv_informacoes.DataSource = dr;
                foreach (var item in enf.TodosEnfermeiro())
                {
                    int linha = dgv_informacoes.Rows.Count;
                    dgv_informacoes.Rows.Add();
                    dgv_informacoes.Rows[linha].Cells[0].Value = enf.Nome;
                    dgv_informacoes.Rows[linha].Cells[1].Value = enf.RG;
                    dgv_informacoes.Rows[linha].Cells[2].Value = enf.CPF;
                    dgv_informacoes.Rows[linha].Cells[3].Value = enf.Coren;
                    dgv_informacoes.Rows[linha].Cells[4].Value = enf.Intervalo;
                    dgv_informacoes.Rows[linha].Cells[5].Value = enf.Turno;
                    dgv_informacoes.Rows[linha].Cells[6].Value = enf.Telefone;
                    dgv_informacoes.Rows[linha].Cells[7].Value = enf.Level.Level;
                }
            }
        }

        private void btn_cracha_Click(object sender, EventArgs e)
        {
            frm_imp_cor coren = new frm_imp_cor();
            coren.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange | Consultar Enfermeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
