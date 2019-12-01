namespace PosiChange.Formulários
{
    partial class frm_cad_ate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_ate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_turno = new System.Windows.Forms.ComboBox();
            this.rbt_acesso = new System.Windows.Forms.RadioButton();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_intervalo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone_cad_enf = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nivel_cad_enf = new System.Windows.Forms.Label();
            this.lbl_intervalo_cad_enf = new System.Windows.Forms.Label();
            this.lbl_turno_cad_enf = new System.Windows.Forms.Label();
            this.lbl_nome_cad_enf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_rg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_turno);
            this.groupBox1.Controls.Add(this.rbt_acesso);
            this.groupBox1.Controls.Add(this.cmb_nivel);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_intervalo);
            this.groupBox1.Controls.Add(this.lbl_telefone_cad_enf);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_nivel_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_intervalo_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_turno_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_nome_cad_enf);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Atendente";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(185, 55);
            this.txt_cpf.MaxLength = 11;
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(84, 20);
            this.txt_cpf.TabIndex = 29;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(49, 54);
            this.txt_rg.MaxLength = 9;
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(84, 20);
            this.txt_rg.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "RG";
            // 
            // cmb_turno
            // 
            this.cmb_turno.FormattingEnabled = true;
            this.cmb_turno.Items.AddRange(new object[] {
            "Diurno",
            "Noturno"});
            this.cmb_turno.Location = new System.Drawing.Point(185, 89);
            this.cmb_turno.Name = "cmb_turno";
            this.cmb_turno.Size = new System.Drawing.Size(85, 21);
            this.cmb_turno.TabIndex = 7;
            // 
            // rbt_acesso
            // 
            this.rbt_acesso.AutoSize = true;
            this.rbt_acesso.Checked = true;
            this.rbt_acesso.Location = new System.Drawing.Point(10, 120);
            this.rbt_acesso.Name = "rbt_acesso";
            this.rbt_acesso.Size = new System.Drawing.Size(100, 17);
            this.rbt_acesso.TabIndex = 27;
            this.rbt_acesso.TabStop = true;
            this.rbt_acesso.Text = "Primeiro Acesso";
            this.rbt_acesso.UseVisualStyleBackColor = true;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(491, 89);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(91, 21);
            this.cmb_nivel.TabIndex = 9;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(483, 54);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(99, 20);
            this.txt_senha.TabIndex = 5;
            // 
            // txt_login
            // 
            this.txt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_login.Location = new System.Drawing.Point(324, 54);
            this.txt_login.MaxLength = 6;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(94, 20);
            this.txt_login.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Login";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(507, 130);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(426, 130);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 14;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(345, 130);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(351, 88);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(84, 20);
            this.txt_telefone.TabIndex = 8;
            // 
            // txt_intervalo
            // 
            this.txt_intervalo.Location = new System.Drawing.Point(79, 88);
            this.txt_intervalo.Mask = "00:00";
            this.txt_intervalo.Name = "txt_intervalo";
            this.txt_intervalo.Size = new System.Drawing.Size(38, 20);
            this.txt_intervalo.TabIndex = 6;
            // 
            // lbl_telefone_cad_enf
            // 
            this.lbl_telefone_cad_enf.AutoSize = true;
            this.lbl_telefone_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_cad_enf.Location = new System.Drawing.Point(276, 89);
            this.lbl_telefone_cad_enf.Name = "lbl_telefone_cad_enf";
            this.lbl_telefone_cad_enf.Size = new System.Drawing.Size(72, 17);
            this.lbl_telefone_cad_enf.TabIndex = 12;
            this.lbl_telefone_cad_enf.Text = "Telefone";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(520, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nivel_cad_enf
            // 
            this.lbl_nivel_cad_enf.AutoSize = true;
            this.lbl_nivel_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_cad_enf.Location = new System.Drawing.Point(446, 89);
            this.lbl_nivel_cad_enf.Name = "lbl_nivel_cad_enf";
            this.lbl_nivel_cad_enf.Size = new System.Drawing.Size(44, 17);
            this.lbl_nivel_cad_enf.TabIndex = 12;
            this.lbl_nivel_cad_enf.Text = "Nivel";
            // 
            // lbl_intervalo_cad_enf
            // 
            this.lbl_intervalo_cad_enf.AutoSize = true;
            this.lbl_intervalo_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo_cad_enf.Location = new System.Drawing.Point(7, 89);
            this.lbl_intervalo_cad_enf.Name = "lbl_intervalo_cad_enf";
            this.lbl_intervalo_cad_enf.Size = new System.Drawing.Size(71, 17);
            this.lbl_intervalo_cad_enf.TabIndex = 12;
            this.lbl_intervalo_cad_enf.Text = "Intervalo";
            // 
            // lbl_turno_cad_enf
            // 
            this.lbl_turno_cad_enf.AutoSize = true;
            this.lbl_turno_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno_cad_enf.Location = new System.Drawing.Point(131, 89);
            this.lbl_turno_cad_enf.Name = "lbl_turno_cad_enf";
            this.lbl_turno_cad_enf.Size = new System.Drawing.Size(51, 17);
            this.lbl_turno_cad_enf.TabIndex = 12;
            this.lbl_turno_cad_enf.Text = "Turno";
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
            // frm_cad_ate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(618, 189);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cad_ate";
            this.Load += new System.EventHandler(this.frm_cad_ate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_intervalo;
        private System.Windows.Forms.Label lbl_telefone_cad_enf;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nivel_cad_enf;
        private System.Windows.Forms.Label lbl_intervalo_cad_enf;
        private System.Windows.Forms.Label lbl_turno_cad_enf;
        private System.Windows.Forms.Label lbl_nome_cad_enf;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.RadioButton rbt_acesso;
        private System.Windows.Forms.ComboBox cmb_turno;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}