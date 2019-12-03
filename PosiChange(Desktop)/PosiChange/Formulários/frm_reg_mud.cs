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
    public partial class frm_reg_mud : Form
    {
        public frm_reg_mud()
        {
            InitializeComponent();
        }

        private void frm_reg_mud_Load(object sender, EventArgs e)
        {
            // Paciente
            DataTable dt = new DataTable();
            Paciente paciente = new Paciente();
            var pacs = paciente.Pacientes();
            dt.Load(pacs);
            cmb_paciente.DataSource = dt;
            cmb_paciente.DisplayMember = "nome";
            cmb_paciente.ValueMember = "cod_pac";
            cmb_paciente.Text = "";

            // Posicao
            DataTable data = new DataTable();
            Posicao posicao = new Posicao();
            var posics = posicao.Posicoes();
            data.Load(posics);
            cmb_posicao.DataSource = dt;
            cmb_posicao.DisplayMember = "posicao";
            cmb_posicao.ValueMember = "cod_pos";
            cmb_posicao.Text = "";
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            Mudanca mudanca = new Mudanca();
            mudanca.Patient = new Paciente();
            mudanca.Position = new Posicao();

            mudanca.Patient.Cod = Convert.ToInt32(cmb_paciente.SelectedValue);
            mudanca.Proxima = Convert.ToDateTime(txt_proxima.Text);
            mudanca.Position.Cod = Convert.ToInt32(cmb_posicao.SelectedValue);
            mudanca.Tempo = Convert.ToDateTime(txt_tolerancia.Text);
            try
            {
                mudanca.Inserir();
            }
            catch (Exception)
            {

                MessageBox.Show("Sinto muito, mas não foi possível gravar as informações",
                    "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
