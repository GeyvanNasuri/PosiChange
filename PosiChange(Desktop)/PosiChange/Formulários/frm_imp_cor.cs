using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using PosiChange.Formulários;
using PosiChange.Classes;

namespace PosiChange.Formulários
{
    public partial class frm_imp_cor : Form
    {
        public frm_imp_cor()
        {
            InitializeComponent();
        }

        private void frm_imp_cor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Enfermeiro enf =new Enfermeiro();
            var enfs = enf.Enfermeiros();
            dt.Load(enfs);
            cmb_enfermeiro.DataSource = dt;
            cmb_enfermeiro.DisplayMember = "nome";
            cmb_enfermeiro.ValueMember = "cod_enf";
            cmb_enfermeiro.Text = "";
        }

        private void btn_gera_qr_Click(object sender, EventArgs e)
        {
            
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txt_coren.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pcb_qr_coren.Image = code.GetGraphic(5);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinto muito, esta aplicação ainda não é capaz de execultar a tarefa",
                "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Enfermeiro enf = new Enfermeiro();
            enf.Select(Convert.ToInt32(cmb_enfermeiro.SelectedValue));
            txt_coren.Text = Convert.ToString(enf.Coren);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar a tela inicial?",
                "PosiChange | Gerar Crachá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
