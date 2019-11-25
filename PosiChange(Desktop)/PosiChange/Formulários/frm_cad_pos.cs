using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PosiChange.Formulários
{
    public partial class frm_cad_pos : Form
    {
        string imgPos;
        public frm_cad_pos()
        {
            InitializeComponent();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog img_pos = new OpenFileDialog();
                img_pos.Filter = "Imagens | *.jpg";
                if (img_pos.ShowDialog() == DialogResult.OK)
                {
                    imgPos = img_pos.FileName;
                    pic_posicao.Image = Image.FromFile(img_pos.FileName);
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
                "PosiChange | Registro de Posições", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                
            }
        }
    }
}
