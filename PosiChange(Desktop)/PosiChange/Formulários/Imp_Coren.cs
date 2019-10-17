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

namespace PosiChange.Formulários
{
    public partial class Imp_Coren : Form
    {
        public Imp_Coren()
        {
            InitializeComponent();
        }

        private void btn_gera_qr_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode("", QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pcb_qr_coren.Image = code.GetGraphic(5);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var respota = MessageBox.Show("Deseja sair?", "PosiChange", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respota == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
