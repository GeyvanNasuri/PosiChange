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
    public partial class frm_pri_adm : Form
    {
        public frm_pri_adm()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_ate ate = new frm_cad_ate();
            ate.MdiParent = this;
            ate.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    // comando para fecha um formalario enquanto carrega outro!
                    this.Hide();
                    Form formL = new frm_login();
                    formL.Closed += (s, args) => this.Close();
                    formL.Show();
                }
            }
        }
    }
}