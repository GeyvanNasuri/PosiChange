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
    public partial class frm_con_pac : Form
    {
        public frm_con_pac()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Paciente pac = new Paciente();
            if (txt_nome.Text != String.Empty)
            {
                var dr = pac.ListaPaciente(txt_nome.Text);
                DataTable dt = new DataTable();
                //dt.Load(dr);
                dgv_informacoes.DataSource = dr;
                foreach (var item in pac.ListaPaciente(txt_nome.Text))
                {
                    int linha = dgv_informacoes.Rows.Count;
                    dgv_informacoes.Rows.Add();
                    dgv_informacoes.Rows[linha].Cells[0].Value = pac.Nome;
                    dgv_informacoes.Rows[linha].Cells[1].Value = pac.RG;
                    dgv_informacoes.Rows[linha].Cells[2].Value = pac.CPF;
                    dgv_informacoes.Rows[linha].Cells[3].Value = pac.Ferida;
                    dgv_informacoes.Rows[linha].Cells[4].Value = pac.Descricao;
                    dgv_informacoes.Rows[linha].Cells[5].Value = pac.Situacao;
                }
            }
            else if (txt_nome.Text == String.Empty)
            {
                var dr = pac.TodosPacientes();
                DataTable dt = new DataTable();
                //dt.Load(dr);
                dgv_informacoes.DataSource = dr;
                foreach (var item in pac.TodosPacientes())
                {
                    int linha = dgv_informacoes.Rows.Count;
                    dgv_informacoes.Rows.Add();
                    dgv_informacoes.Rows[linha].Cells[0].Value = pac.Nome;
                    dgv_informacoes.Rows[linha].Cells[1].Value = pac.RG;
                    dgv_informacoes.Rows[linha].Cells[2].Value = pac.CPF;
                    dgv_informacoes.Rows[linha].Cells[3].Value = pac.Ferida;
                    dgv_informacoes.Rows[linha].Cells[4].Value = pac.Descricao;
                    dgv_informacoes.Rows[linha].Cells[5].Value = pac.Situacao;
                }
            }

        }
    }
}
