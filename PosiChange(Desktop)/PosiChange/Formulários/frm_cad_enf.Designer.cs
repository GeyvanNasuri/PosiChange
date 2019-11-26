namespace PosiChange.Formulários
{
    partial class frm_cad_enf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_enf));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_intervalo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone_cad_enf = new System.Windows.Forms.Label();
            this.txt_turno = new System.Windows.Forms.TextBox();
            this.txt_coren = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nivel_cad_enf = new System.Windows.Forms.Label();
            this.lbl_intervalo_cad_enf = new System.Windows.Forms.Label();
            this.lbl_turno_cad_enf = new System.Windows.Forms.Label();
            this.lbl_coren_cad_enf = new System.Windows.Forms.Label();
            this.lbl_nome_cad_enf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_rg);
            this.groupBox1.Controls.Add(this.cmb_nivel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_intervalo);
            this.groupBox1.Controls.Add(this.lbl_telefone_cad_enf);
            this.groupBox1.Controls.Add(this.txt_turno);
            this.groupBox1.Controls.Add(this.txt_coren);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_nivel_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_intervalo_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_turno_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_coren_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_nome_cad_enf);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Enfermeiro";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(209, 55);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(84, 20);
            this.txt_cpf.TabIndex = 3;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(62, 54);
            this.txt_rg.Mask = "00.000.000-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(84, 20);
            this.txt_rg.TabIndex = 2;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(350, 55);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(92, 21);
            this.cmb_nivel.TabIndex = 4;
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
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(512, 123);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_vol_enf_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(431, 123);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 14;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_ver_enf_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(350, 123);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(367, 87);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(90, 20);
            this.txt_telefone.TabIndex = 8;
            // 
            // txt_intervalo
            // 
            this.txt_intervalo.Location = new System.Drawing.Point(232, 87);
            this.txt_intervalo.Mask = "00:00";
            this.txt_intervalo.Name = "txt_intervalo";
            this.txt_intervalo.Size = new System.Drawing.Size(38, 20);
            this.txt_intervalo.TabIndex = 7;
            // 
            // lbl_telefone_cad_enf
            // 
            this.lbl_telefone_cad_enf.AutoSize = true;
            this.lbl_telefone_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_cad_enf.Location = new System.Drawing.Point(288, 88);
            this.lbl_telefone_cad_enf.Name = "lbl_telefone_cad_enf";
            this.lbl_telefone_cad_enf.Size = new System.Drawing.Size(72, 17);
            this.lbl_telefone_cad_enf.TabIndex = 12;
            this.lbl_telefone_cad_enf.Text = "Telefone";
            // 
            // txt_turno
            // 
            this.txt_turno.Location = new System.Drawing.Point(64, 87);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(84, 20);
            this.txt_turno.TabIndex = 6;
            // 
            // txt_coren
            // 
            this.txt_coren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_coren.Location = new System.Drawing.Point(503, 54);
            this.txt_coren.MaxLength = 6;
            this.txt_coren.Name = "txt_coren";
            this.txt_coren.Size = new System.Drawing.Size(84, 20);
            this.txt_coren.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(525, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nivel_cad_enf
            // 
            this.lbl_nivel_cad_enf.AutoSize = true;
            this.lbl_nivel_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_cad_enf.Location = new System.Drawing.Point(304, 55);
            this.lbl_nivel_cad_enf.Name = "lbl_nivel_cad_enf";
            this.lbl_nivel_cad_enf.Size = new System.Drawing.Size(44, 17);
            this.lbl_nivel_cad_enf.TabIndex = 12;
            this.lbl_nivel_cad_enf.Text = "Nivel";
            // 
            // lbl_intervalo_cad_enf
            // 
            this.lbl_intervalo_cad_enf.AutoSize = true;
            this.lbl_intervalo_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo_cad_enf.Location = new System.Drawing.Point(155, 87);
            this.lbl_intervalo_cad_enf.Name = "lbl_intervalo_cad_enf";
            this.lbl_intervalo_cad_enf.Size = new System.Drawing.Size(71, 17);
            this.lbl_intervalo_cad_enf.TabIndex = 12;
            this.lbl_intervalo_cad_enf.Text = "Intervalo";
            // 
            // lbl_turno_cad_enf
            // 
            this.lbl_turno_cad_enf.AutoSize = true;
            this.lbl_turno_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno_cad_enf.Location = new System.Drawing.Point(7, 87);
            this.lbl_turno_cad_enf.Name = "lbl_turno_cad_enf";
            this.lbl_turno_cad_enf.Size = new System.Drawing.Size(51, 17);
            this.lbl_turno_cad_enf.TabIndex = 12;
            this.lbl_turno_cad_enf.Text = "Turno";
            // 
            // lbl_coren_cad_enf
            // 
            this.lbl_coren_cad_enf.AutoSize = true;
            this.lbl_coren_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coren_cad_enf.Location = new System.Drawing.Point(448, 54);
            this.lbl_coren_cad_enf.Name = "lbl_coren_cad_enf";
            this.lbl_coren_cad_enf.Size = new System.Drawing.Size(51, 17);
            this.lbl_coren_cad_enf.TabIndex = 12;
            this.lbl_coren_cad_enf.Text = "Coren";
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
            // frm_cad_enf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(626, 186);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cad_enf";
            this.Load += new System.EventHandler(this.Cad_Enf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nome_cad_enf;
        private System.Windows.Forms.Label lbl_nivel_cad_enf;
        private System.Windows.Forms.Label lbl_telefone_cad_enf;
        private System.Windows.Forms.Label lbl_intervalo_cad_enf;
        private System.Windows.Forms.Label lbl_turno_cad_enf;
        private System.Windows.Forms.Label lbl_coren_cad_enf;
        private System.Windows.Forms.TextBox txt_coren;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_intervalo;
        private System.Windows.Forms.TextBox txt_turno;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
    }
}