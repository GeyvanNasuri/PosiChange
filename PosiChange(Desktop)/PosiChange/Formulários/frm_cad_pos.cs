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
using PosiChange.Classes;

namespace PosiChange.Formulários
{
    public partial class frm_cad_pos : Form
    {
        public frm_cad_pos()
        {
            InitializeComponent();
        }

        private void frm_cad_pos_Load(object sender, EventArgs e)
        {

        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            // Instancia para Localizar a imagem!
            try
            {
                OpenFileDialog img_pos = new OpenFileDialog();
                img_pos.Filter = "JPG Files(*.jpeg) |*.jpg |PNG Files(*.png)|*png |AllFiles(*.*) |*.*";
                if (img_pos.ShowDialog() == DialogResult.OK)
                {
                    string imgPos = img_pos.FileName.ToString();
                    txt_caminho.Text = imgPos;
                    //pic_posicao.Image = Image.FromFile(img_pos.FileName);
                    pic_posicao.ImageLocation = imgPos;
                }
            }
            catch (Exception Ex)
            {
                //throw Ex;
                MessageBox.Show("Sinto Muito, mas não consegui buscar a imagem", "PosiChange",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja voltar para a janela principal?",
                "PosiChange | Registro de Posições", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //byte[] img = null;
            FileStream stream = new FileStream(this.txt_caminho.Text, FileMode.Open, FileAccess.Read);
            BinaryReader binary = new BinaryReader(stream);
            byte[] img = binary.ReadBytes((int)stream.Length);
            Posicao posicao = new Posicao();
            posicao.Position = txt_posicao.Text;
            //posicao.Imagem = img;
            try
            {
                posicao.Inserir();
                if (posicao.Cod > 0)
                {
                    var gravou = MessageBox.Show("Nova posição gravada com sucesso! Porém, não foi possível gravar a imagem!",
                        "PosiChange | Cadastro de Posicao",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (gravou == DialogResult.OK)
                    {
                        pic_posicao.Image = null;
                        txt_posicao.Clear();
                        txt_caminho.Clear();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;

                MessageBox.Show("Sinto muito, mas não cosegui gravar as informações",
                    "PosiChange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
