﻿using System;
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

        private void Principal_Aten_Load(object sender, EventArgs e)
        {
            //Color.Yellow;
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
            enf.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Con_Enf enf = new Con_Enf();
            enf.ShowDialog();
        }

        private void gerarCracháToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imp_Coren cracha = new Imp_Coren();
            cracha.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cad_Pac pac = new Cad_Pac();
            pac.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Pac pac = new Con_Pac();
            pac.ShowDialog();
        }
    }
}