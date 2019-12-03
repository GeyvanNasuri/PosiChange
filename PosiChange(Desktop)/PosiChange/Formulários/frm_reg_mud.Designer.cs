namespace PosiChange.Formulários
{
    partial class frm_reg_mud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reg_mud));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_paciente = new System.Windows.Forms.ComboBox();
            this.cmb_posicao = new System.Windows.Forms.ComboBox();
            this.txt_proxima = new System.Windows.Forms.MaskedTextBox();
            this.txt_tolerancia = new System.Windows.Forms.MaskedTextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.btn_inserir);
            this.groupBox1.Controls.Add(this.txt_tolerancia);
            this.groupBox1.Controls.Add(this.txt_proxima);
            this.groupBox1.Controls.Add(this.cmb_posicao);
            this.groupBox1.Controls.Add(this.cmb_paciente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Mudanças de Posições";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Próxima Troca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tolerância";
            // 
            // cmb_paciente
            // 
            this.cmb_paciente.FormattingEnabled = true;
            this.cmb_paciente.Location = new System.Drawing.Point(75, 31);
            this.cmb_paciente.Name = "cmb_paciente";
            this.cmb_paciente.Size = new System.Drawing.Size(227, 21);
            this.cmb_paciente.TabIndex = 4;
            // 
            // cmb_posicao
            // 
            this.cmb_posicao.FormattingEnabled = true;
            this.cmb_posicao.Location = new System.Drawing.Point(70, 70);
            this.cmb_posicao.Name = "cmb_posicao";
            this.cmb_posicao.Size = new System.Drawing.Size(232, 21);
            this.cmb_posicao.TabIndex = 5;
            // 
            // txt_proxima
            // 
            this.txt_proxima.Location = new System.Drawing.Point(112, 107);
            this.txt_proxima.Mask = "00:00";
            this.txt_proxima.Name = "txt_proxima";
            this.txt_proxima.Size = new System.Drawing.Size(39, 20);
            this.txt_proxima.TabIndex = 8;
            // 
            // txt_tolerancia
            // 
            this.txt_tolerancia.Location = new System.Drawing.Point(268, 107);
            this.txt_tolerancia.Mask = "00:00";
            this.txt_tolerancia.Name = "txt_tolerancia";
            this.txt_tolerancia.Size = new System.Drawing.Size(34, 20);
            this.txt_tolerancia.TabIndex = 9;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(330, 29);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 10;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(330, 68);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // frm_reg_mud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(434, 168);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reg_mud";
            this.Load += new System.EventHandler(this.frm_reg_mud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.MaskedTextBox txt_tolerancia;
        private System.Windows.Forms.MaskedTextBox txt_proxima;
        private System.Windows.Forms.ComboBox cmb_posicao;
        private System.Windows.Forms.ComboBox cmb_paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}