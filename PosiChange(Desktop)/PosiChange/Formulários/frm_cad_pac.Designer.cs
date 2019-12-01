namespace PosiChange.Formulários
{
    partial class frm_cad_pac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_pac));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_nao = new System.Windows.Forms.RadioButton();
            this.rbt_sim = new System.Windows.Forms.RadioButton();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_vol_enf = new System.Windows.Forms.Button();
            this.btn_cad_enf = new System.Windows.Forms.Button();
            this.txt_situacao = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nivel_cad_enf = new System.Windows.Forms.Label();
            this.lbl_turno_cad_enf = new System.Windows.Forms.Label();
            this.lbl_coren_cad_enf = new System.Windows.Forms.Label();
            this.lbl_nome_cad_enf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_nao);
            this.groupBox1.Controls.Add(this.rbt_sim);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_rg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_vol_enf);
            this.groupBox1.Controls.Add(this.btn_cad_enf);
            this.groupBox1.Controls.Add(this.txt_situacao);
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_nivel_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_turno_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_coren_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_nome_cad_enf);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Paciente";
            // 
            // rbt_nao
            // 
            this.rbt_nao.AutoSize = true;
            this.rbt_nao.Location = new System.Drawing.Point(491, 57);
            this.rbt_nao.Name = "rbt_nao";
            this.rbt_nao.Size = new System.Drawing.Size(45, 17);
            this.rbt_nao.TabIndex = 24;
            this.rbt_nao.TabStop = true;
            this.rbt_nao.Text = "Não";
            this.rbt_nao.UseVisualStyleBackColor = true;
            this.rbt_nao.CheckedChanged += new System.EventHandler(this.rbt_nao_CheckedChanged);
            // 
            // rbt_sim
            // 
            this.rbt_sim.AutoSize = true;
            this.rbt_sim.Location = new System.Drawing.Point(443, 56);
            this.rbt_sim.Name = "rbt_sim";
            this.rbt_sim.Size = new System.Drawing.Size(42, 17);
            this.rbt_sim.TabIndex = 23;
            this.rbt_sim.TabStop = true;
            this.rbt_sim.Text = "Sim";
            this.rbt_sim.UseVisualStyleBackColor = true;
            this.rbt_sim.CheckedChanged += new System.EventHandler(this.rbt_sim_CheckedChanged);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(209, 55);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(84, 20);
            this.txt_cpf.TabIndex = 22;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(62, 54);
            this.txt_rg.Mask = "00.000.000-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(84, 20);
            this.txt_rg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "RG";
            // 
            // btn_vol_enf
            // 
            this.btn_vol_enf.Location = new System.Drawing.Point(458, 156);
            this.btn_vol_enf.Name = "btn_vol_enf";
            this.btn_vol_enf.Size = new System.Drawing.Size(75, 23);
            this.btn_vol_enf.TabIndex = 15;
            this.btn_vol_enf.Text = "Voltar";
            this.btn_vol_enf.UseVisualStyleBackColor = true;
            this.btn_vol_enf.Click += new System.EventHandler(this.btn_vol_enf_Click);
            // 
            // btn_cad_enf
            // 
            this.btn_cad_enf.Location = new System.Drawing.Point(296, 156);
            this.btn_cad_enf.Name = "btn_cad_enf";
            this.btn_cad_enf.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_enf.TabIndex = 13;
            this.btn_cad_enf.Text = "Cadastrar";
            this.btn_cad_enf.UseVisualStyleBackColor = true;
            this.btn_cad_enf.Click += new System.EventHandler(this.btn_cad_enf_Click);
            // 
            // txt_situacao
            // 
            this.txt_situacao.Location = new System.Drawing.Point(175, 119);
            this.txt_situacao.Name = "txt_situacao";
            this.txt_situacao.Size = new System.Drawing.Size(358, 20);
            this.txt_situacao.TabIndex = 5;
            // 
            // txt_descricao
            // 
            this.txt_descricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_descricao.Location = new System.Drawing.Point(167, 87);
            this.txt_descricao.MaxLength = 150;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(366, 20);
            this.txt_descricao.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(471, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nivel_cad_enf
            // 
            this.lbl_nivel_cad_enf.AutoSize = true;
            this.lbl_nivel_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_cad_enf.Location = new System.Drawing.Point(304, 55);
            this.lbl_nivel_cad_enf.Name = "lbl_nivel_cad_enf";
            this.lbl_nivel_cad_enf.Size = new System.Drawing.Size(133, 17);
            this.lbl_nivel_cad_enf.TabIndex = 12;
            this.lbl_nivel_cad_enf.Text = "Apresenta Ferida";
            // 
            // lbl_turno_cad_enf
            // 
            this.lbl_turno_cad_enf.AutoSize = true;
            this.lbl_turno_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno_cad_enf.Location = new System.Drawing.Point(7, 119);
            this.lbl_turno_cad_enf.Name = "lbl_turno_cad_enf";
            this.lbl_turno_cad_enf.Size = new System.Drawing.Size(162, 17);
            this.lbl_turno_cad_enf.TabIndex = 12;
            this.lbl_turno_cad_enf.Text = "Situação do Paciente";
            // 
            // lbl_coren_cad_enf
            // 
            this.lbl_coren_cad_enf.AutoSize = true;
            this.lbl_coren_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coren_cad_enf.Location = new System.Drawing.Point(7, 88);
            this.lbl_coren_cad_enf.Name = "lbl_coren_cad_enf";
            this.lbl_coren_cad_enf.Size = new System.Drawing.Size(154, 17);
            this.lbl_coren_cad_enf.TabIndex = 12;
            this.lbl_coren_cad_enf.Text = "Descrição da Ferida";
            // 
            // lbl_nome_cad_enf
            // 
            this.lbl_nome_cad_enf.AutoSize = true;
            this.lbl_nome_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cad_enf.Location = new System.Drawing.Point(7, 20);
            this.lbl_nome_cad_enf.Name = "lbl_nome_cad_enf";
            this.lbl_nome_cad_enf.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome_cad_enf.TabIndex = 12;
            this.lbl_nome_cad_enf.Text = "Nome";
            // 
            // frm_cad_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(567, 218);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cad_pac";
            this.Load += new System.EventHandler(this.Cad_Pac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_vol_enf;
        private System.Windows.Forms.Button btn_cad_enf;
        private System.Windows.Forms.TextBox txt_situacao;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nivel_cad_enf;
        private System.Windows.Forms.Label lbl_turno_cad_enf;
        private System.Windows.Forms.Label lbl_coren_cad_enf;
        private System.Windows.Forms.Label lbl_nome_cad_enf;
        private System.Windows.Forms.RadioButton rbt_nao;
        private System.Windows.Forms.RadioButton rbt_sim;
    }
}