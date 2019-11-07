namespace PosiChange.Formulários
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sair_login = new System.Windows.Forms.Button();
            this.btn_entrar_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senha_login = new System.Windows.Forms.TextBox();
            this.txt_usuario_login = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_sair_login);
            this.groupBox1.Controls.Add(this.btn_entrar_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_senha_login);
            this.groupBox1.Controls.Add(this.txt_usuario_login);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carregar Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 138);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sair_login
            // 
            this.btn_sair_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair_login.Location = new System.Drawing.Point(156, 351);
            this.btn_sair_login.Name = "btn_sair_login";
            this.btn_sair_login.Size = new System.Drawing.Size(141, 41);
            this.btn_sair_login.TabIndex = 5;
            this.btn_sair_login.Text = "Sair";
            this.btn_sair_login.UseVisualStyleBackColor = false;
            this.btn_sair_login.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_entrar_login
            // 
            this.btn_entrar_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar_login.Location = new System.Drawing.Point(6, 351);
            this.btn_entrar_login.Name = "btn_entrar_login";
            this.btn_entrar_login.Size = new System.Drawing.Size(141, 41);
            this.btn_entrar_login.TabIndex = 4;
            this.btn_entrar_login.Text = "Entrar";
            this.btn_entrar_login.UseVisualStyleBackColor = false;
            this.btn_entrar_login.Click += new System.EventHandler(this.btn_entrar_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha do Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login do Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_senha_login
            // 
            this.txt_senha_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha_login.Location = new System.Drawing.Point(72, 277);
            this.txt_senha_login.Name = "txt_senha_login";
            this.txt_senha_login.PasswordChar = '*';
            this.txt_senha_login.Size = new System.Drawing.Size(141, 27);
            this.txt_senha_login.TabIndex = 1;
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_login.Location = new System.Drawing.Point(72, 193);
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(141, 27);
            this.txt_usuario_login.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(327, 422);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_senha_login;
        private System.Windows.Forms.TextBox txt_usuario_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_entrar_login;
        private System.Windows.Forms.Button btn_sair_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}