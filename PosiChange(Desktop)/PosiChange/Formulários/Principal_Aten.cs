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
    public partial class Principal_Aten : Form
    {
        public Principal_Aten()
        {
            InitializeComponent();
        }

        private void Principal_Aten_Load(object sender, EventArgs e)
        {
            Infracao inf = new Infracao();
            if (inf.Ocorrencia() == true)
            {

            }
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
                    Principal_Aten aten = new Principal_Aten();
                    Login login = new Login();
                    aten.Hide();
                    login.ShowDialog();
                }
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Enf enf = new Cad_Enf();
            enf.MdiParent = this;
            enf.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Con_Enf enf = new Con_Enf();
            enf.MdiParent = this;
            enf.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cad_Pac pac = new Cad_Pac();
            pac.MdiParent = this;
            pac.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Pac pac = new Con_Pac();
            pac.MdiParent = this;
            pac.Show();
        }

        private void infraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btn_infracao infracao = Color.Red;
        }

        private void resgistrarResponsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}