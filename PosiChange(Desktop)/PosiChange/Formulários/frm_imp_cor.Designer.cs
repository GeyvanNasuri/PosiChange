namespace PosiChange.Formulários
{
    partial class frm_imp_cor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_imp_cor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_coren = new System.Windows.Forms.TextBox();
            this.cmb_enfermeiro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_atuacao = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_gera_qr = new System.Windows.Forms.Button();
            this.pcb_qr_coren = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qr_coren)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_coren);
            this.groupBox1.Controls.Add(this.cmb_enfermeiro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_atuacao);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_gera_qr);
            this.groupBox1.Controls.Add(this.pcb_qr_coren);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QR Code";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(302, 81);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_coren
            // 
            this.txt_coren.Enabled = false;
            this.txt_coren.Location = new System.Drawing.Point(64, 83);
            this.txt_coren.Name = "txt_coren";
            this.txt_coren.Size = new System.Drawing.Size(100, 20);
            this.txt_coren.TabIndex = 8;
            // 
            // cmb_enfermeiro
            // 
            this.cmb_enfermeiro.FormattingEnabled = true;
            this.cmb_enfermeiro.Location = new System.Drawing.Point(64, 25);
            this.cmb_enfermeiro.Name = "cmb_enfermeiro";
            this.cmb_enfermeiro.Size = new System.Drawing.Size(313, 21);
            this.cmb_enfermeiro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "QR Code";
            // 
            // lbl_atuacao
            // 
            this.lbl_atuacao.AutoSize = true;
            this.lbl_atuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atuacao.Location = new System.Drawing.Point(16, 84);
            this.lbl_atuacao.Name = "lbl_atuacao";
            this.lbl_atuacao.Size = new System.Drawing.Size(45, 15);
            this.lbl_atuacao.TabIndex = 5;
            this.lbl_atuacao.Text = "Coren";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(13, 26);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 15);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(302, 483);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cancelar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(160, 483);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_gera_qr
            // 
            this.btn_gera_qr.Location = new System.Drawing.Point(16, 483);
            this.btn_gera_qr.Name = "btn_gera_qr";
            this.btn_gera_qr.Size = new System.Drawing.Size(88, 23);
            this.btn_gera_qr.TabIndex = 1;
            this.btn_gera_qr.Text = "Gerar Qr Code";
            this.btn_gera_qr.UseVisualStyleBackColor = true;
            this.btn_gera_qr.Click += new System.EventHandler(this.btn_gera_qr_Click);
            // 
            // pcb_qr_coren
            // 
            this.pcb_qr_coren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcb_qr_coren.Location = new System.Drawing.Point(16, 150);
            this.pcb_qr_coren.Name = "pcb_qr_coren";
            this.pcb_qr_coren.Size = new System.Drawing.Size(359, 327);
            this.pcb_qr_coren.TabIndex = 0;
            this.pcb_qr_coren.TabStop = false;
            // 
            // frm_imp_cor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(417, 552);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_imp_cor";
            this.Load += new System.EventHandler(this.frm_imp_cor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_qr_coren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcb_qr_coren;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_gera_qr;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_coren;
        private System.Windows.Forms.ComboBox cmb_enfermeiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_atuacao;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_buscar;
    }
}