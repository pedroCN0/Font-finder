namespace Projeto_Hesp_estudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btlogar = new System.Windows.Forms.Button();
            this.tlog = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.tsenha = new System.Windows.Forms.Label();
            this.tnome = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btlogar
            // 
            this.btlogar.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.btlogar, "btlogar");
            this.btlogar.Name = "btlogar";
            this.btlogar.UseVisualStyleBackColor = false;
            this.btlogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlog
            // 
            resources.ApplyResources(this.tlog, "tlog");
            this.tlog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlog.Name = "tlog";
            this.tlog.Click += new System.EventHandler(this.tlog_Click);
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // tsenha
            // 
            resources.ApplyResources(this.tsenha, "tsenha");
            this.tsenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsenha.Name = "tsenha";
            // 
            // tnome
            // 
            resources.ApplyResources(this.tnome, "tnome");
            this.tnome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tnome.Name = "tnome";
            // 
            // senha
            // 
            resources.ApplyResources(this.senha, "senha");
            this.senha.Name = "senha";
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.btcadastrar, "btcadastrar");
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.tnome);
            this.Controls.Add(this.tsenha);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tlog);
            this.Controls.Add(this.btlogar);
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Entrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogar;
        private System.Windows.Forms.Label tlog;
        private System.Windows.Forms.Label tsenha;
        private System.Windows.Forms.Label tnome;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button btcadastrar;
        public System.Windows.Forms.TextBox email;
    }
}