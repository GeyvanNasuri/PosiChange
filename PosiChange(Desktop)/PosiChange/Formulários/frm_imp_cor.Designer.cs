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
            this.groupBox1.Controls.Add(this.lbl_atuacao);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_gera_qr);
            this.groupBox1.Controls.Add(this.pcb_qr_coren);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 598);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QR Code";
            // 
            // lbl_atuacao
            // 
            this.lbl_atuacao.AutoSize = true;
            this.lbl_atuacao.Location = new System.Drawing.Point(75, 33);
            this.lbl_atuacao.Name = "lbl_atuacao";
            this.lbl_atuacao.Size = new System.Drawing.Size(35, 13);
            this.lbl_atuacao.TabIndex = 5;
            this.lbl_atuacao.Text = "label2";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(16, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "label1";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(302, 568);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Cancelar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(158, 569);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_gera_qr
            // 
            this.btn_gera_qr.Location = new System.Drawing.Point(19, 569);
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
            this.pcb_qr_coren.Location = new System.Drawing.Point(19, 224);
            this.pcb_qr_coren.Name = "pcb_qr_coren";
            this.pcb_qr_coren.Size = new System.Drawing.Size(359, 327);
            this.pcb_qr_coren.TabIndex = 0;
            this.pcb_qr_coren.TabStop = false;
            // 
            // Imp_Coren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(417, 622);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Imp_Coren";
            this.Text = "Crachá";
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
        private System.Windows.Forms.Label lbl_atuacao;
        private System.Windows.Forms.Label lbl_nome;
    }
}