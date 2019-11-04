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
    public partial class Cad_Enf : Form
    {
        public Cad_Enf()
        {
            InitializeComponent();
        }

        private void Cad_Enf_Load(object sender, EventArgs e)
        {
            btn_cad_enf.Enabled = false;
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
            if (true)
            {
                btn_cad_enf.Enabled = true;
            }
        }
    }
}
