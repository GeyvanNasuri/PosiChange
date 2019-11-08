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
    public partial class Principal_Aten : Form
    {

        public Principal_Aten()
        {
            InitializeComponent();
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

                }
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Enf enf = new Cad_Enf();
            enf.ShowDialog();
        }
    }
}
