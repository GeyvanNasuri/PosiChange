namespace PosiChange.Formulários
{
    partial class frm_pri_adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pri_adm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enfermeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_ate = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_con_ate = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_reg_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_con_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enfermeiroToolStripMenuItem,
            this.posiçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enfermeiroToolStripMenuItem
            // 
            this.enfermeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cad_ate,
            this.btn_con_ate});
            this.enfermeiroToolStripMenuItem.Name = "enfermeiroToolStripMenuItem";
            this.enfermeiroToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.enfermeiroToolStripMenuItem.Text = "&Atendimento";
            // 
            // btn_cad_ate
            // 
            this.btn_cad_ate.Name = "btn_cad_ate";
            this.btn_cad_ate.Size = new System.Drawing.Size(125, 22);
            this.btn_cad_ate.Text = "&Cadastrar";
            this.btn_cad_ate.Click += new System.EventHandler(this.btn_cad_ate_Click);
            // 
            // btn_con_ate
            // 
            this.btn_con_ate.Name = "btn_con_ate";
            this.btn_con_ate.Size = new System.Drawing.Size(125, 22);
            this.btn_con_ate.Text = "C&onsultar";
            this.btn_con_ate.Click += new System.EventHandler(this.btn_con_ate_Click);
            // 
            // posiçõesToolStripMenuItem
            // 
            this.posiçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reg_pos,
            this.btn_con_pos});
            this.posiçõesToolStripMenuItem.Name = "posiçõesToolStripMenuItem";
            this.posiçõesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.posiçõesToolStripMenuItem.Text = "&Posições";
            // 
            // btn_reg_pos
            // 
            this.btn_reg_pos.Name = "btn_reg_pos";
            this.btn_reg_pos.Size = new System.Drawing.Size(125, 22);
            this.btn_reg_pos.Text = "&Registrar";
            this.btn_reg_pos.Click += new System.EventHandler(this.btn_reg_pos_Click);
            // 
            // btn_con_pos
            // 
            this.btn_con_pos.Name = "btn_con_pos";
            this.btn_con_pos.Size = new System.Drawing.Size(125, 22);
            this.btn_con_pos.Text = "&Consultar";
            this.btn_con_pos.Click += new System.EventHandler(this.btn_con_pos_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frm_pri_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PosiChange.Properties.Resources.nurse;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_pri_adm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_cad_ate;
        private System.Windows.Forms.ToolStripMenuItem btn_con_ate;
        private System.Windows.Forms.ToolStripMenuItem posiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_reg_pos;
        private System.Windows.Forms.ToolStripMenuItem btn_con_pos;
    }
}