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
    public partial class Cad_Enf : Form
    {
        public Cad_Enf()
        {
            InitializeComponent();
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
    }
}
