namespace PosiChange.Formulários
{
    partial class frm_pri_ate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pri_ate));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enfermeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_enf = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_con_enf = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_pac = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_con_pac = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reg_res = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_quarto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_historico = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_monitor = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_infracao = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_agendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cracha = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mudanca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enfermeiroToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.btn_quarto,
            this.btn_historico,
            this.btn_monitor,
            this.btn_infracao,
            this.btn_agendamento,
            this.btn_cracha,
            this.btn_mudanca,
            this.btn_sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enfermeiroToolStripMenuItem
            // 
            this.enfermeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_enf,
            this.btn_con_enf});
            this.enfermeiroToolStripMenuItem.Name = "enfermeiroToolStripMenuItem";
            this.enfermeiroToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.enfermeiroToolStripMenuItem.Text = "&Enfermagem";
            // 
            // btn_cad_enf
            // 
            this.btn_cad_enf.Name = "btn_cad_enf";
            this.btn_cad_enf.Size = new System.Drawing.Size(125, 22);
            this.btn_cad_enf.Text = "&Cadastrar";
            this.btn_cad_enf.Click += new System.EventHandler(this.btn_cad_enf_Click);
            // 
            // btn_con_enf
            // 
            this.btn_con_enf.Name = "btn_con_enf";
            this.btn_con_enf.Size = new System.Drawing.Size(125, 22);
            this.btn_con_enf.Text = "C&onsultar";
            this.btn_con_enf.Click += new System.EventHandler(this.btn_con_enf_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_pac,
            this.btn_con_pac,
            this.btn_reg_res});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "&Paciente";
            // 
            // btn_cad_pac
            // 
            this.btn_cad_pac.Name = "btn_cad_pac";
            this.btn_cad_pac.Size = new System.Drawing.Size(188, 22);
            this.btn_cad_pac.Text = "&Cadastrar";
            this.btn_cad_pac.Click += new System.EventHandler(this.btn_cad_pac_Click);
            // 
            // btn_con_pac
            // 
            this.btn_con_pac.Name = "btn_con_pac";
            this.btn_con_pac.Size = new System.Drawing.Size(188, 22);
            this.btn_con_pac.Text = "C&onsultar";
            this.btn_con_pac.Click += new System.EventHandler(this.btn_con_pac_Click);
            // 
            // btn_reg_res
            // 
            this.btn_reg_res.Name = "btn_reg_res";
            this.btn_reg_res.Size = new System.Drawing.Size(188, 22);
            this.btn_reg_res.Text = "&Registrar Responsável";
            this.btn_reg_res.Click += new System.EventHandler(this.btn_reg_res_Click);
            // 
            // btn_quarto
            // 
            this.btn_quarto.Name = "btn_quarto";
            this.btn_quarto.Size = new System.Drawing.Size(61, 20);
            this.btn_quarto.Text = "&Quartos";
            this.btn_quarto.Click += new System.EventHandler(this.btn_quarto_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(67, 20);
            this.btn_historico.Text = "&Histórico";
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_monitor
            // 
            this.btn_monitor.Name = "btn_monitor";
            this.btn_monitor.Size = new System.Drawing.Size(103, 20);
            this.btn_monitor.Text = "&Monitoramento";
            this.btn_monitor.Click += new System.EventHandler(this.btn_monitor_Click);
            // 
            // btn_infracao
            // 
            this.btn_infracao.Name = "btn_infracao";
            this.btn_infracao.Size = new System.Drawing.Size(67, 20);
            this.btn_infracao.Text = "&Infrações";
            this.btn_infracao.Click += new System.EventHandler(this.btn_infracao_Click);
            // 
            // btn_agendamento
            // 
            this.btn_agendamento.Name = "btn_agendamento";
            this.btn_agendamento.Size = new System.Drawing.Size(100, 20);
            this.btn_agendamento.Text = "&Agendamentos";
            this.btn_agendamento.Click += new System.EventHandler(this.btn_agendamento_Click_1);
            // 
            // btn_cracha
            // 
            this.btn_cracha.Name = "btn_cracha";
            this.btn_cracha.Size = new System.Drawing.Size(56, 20);
            this.btn_cracha.Text = "&Crachá";
            this.btn_cracha.Click += new System.EventHandler(this.btn_cracha_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(38, 20);
            this.btn_sair.Text = "&Sair";
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_mudanca
            // 
            this.btn_mudanca.Name = "btn_mudanca";
            this.btn_mudanca.Size = new System.Drawing.Size(69, 20);
            this.btn_mudanca.Text = "&Mudança";
            this.btn_mudanca.Click += new System.EventHandler(this.btn_mudanca_Click);
            // 
            // frm_pri_ate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PosiChange.Properties.Resources.nurse;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_pri_ate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Aten_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_sair;
        private System.Windows.Forms.ToolStripMenuItem enfermeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_enf;
        private System.Windows.Forms.ToolStripMenuItem btn_con_enf;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_pac;
        private System.Windows.Forms.ToolStripMenuItem btn_con_pac;
        private System.Windows.Forms.ToolStripMenuItem btn_reg_res;
        private System.Windows.Forms.ToolStripMenuItem btn_quarto;
        private System.Windows.Forms.ToolStripMenuItem btn_historico;
        private System.Windows.Forms.ToolStripMenuItem btn_monitor;
        private System.Windows.Forms.ToolStripMenuItem btn_infracao;
        private System.Windows.Forms.ToolStripMenuItem btn_agendamento;
        private System.Windows.Forms.ToolStripMenuItem btn_cracha;
        private System.Windows.Forms.ToolStripMenuItem btn_mudanca;
    }
}