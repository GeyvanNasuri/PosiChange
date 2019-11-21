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
    public partial class Cad_Pac : Form
    {
        public Cad_Pac()
        {
            InitializeComponent();
        }

        private void Cad_Pac_Load(object sender, EventArgs e)
        {
            txt_descricao.Enabled = false;
        }
    }
}
